using Aplicacion.Services.ExcepcionLogServices;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebServices.Middleware
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public GlobalExceptionHandlingMiddleware(
            ILogger<GlobalExceptionHandlingMiddleware> logger,
            IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                // 1. Identificar si es una excepción provocada por nuestras cláusulas de guarda (Error del Cliente)
                if (e is ArgumentNullException || e is ArgumentException)
                {
                    _logger.LogWarning($"Petición inválida detectada: {e.Message}");

                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest; // HTTP 400
                    context.Response.ContentType = "application/json";

                    var badRequestResponse = new
                    {
                        status = (int)HttpStatusCode.BadRequest,
                        title = "Bad Request",
                        ValidationErrorMessage = e.Message // Le mostramos exactamente qué campo falló
                    };

                    await context.Response.WriteAsync(JsonSerializer.Serialize(badRequestResponse));
                    return; // Detenemos la ejecución aquí sin registrar en la BD de excepciones críticas
                }

                // =========================================================================
                // 2. Si llega aquí, es un error real del servidor (HTTP 500 - Bug o Caída de BD)
                // =========================================================================
                _logger.LogError(e, e.Message);

                var referenciaError = await GuardarExcepcionEnBD(e, context);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // HTTP 500
                context.Response.ContentType = "application/json";

                var errorResponse = new
                {
                    status = (int)HttpStatusCode.InternalServerError,
                    title = "Server Error",
                    ValidationErrorMessage = $"Ha ocurrido un error interno en el servidor. Por favor contacte al soporte si el problema persiste. reference Error {referenciaError}",
                    isSuccess = false
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
            }
        }

        private async Task<int?> GuardarExcepcionEnBD(Exception e, HttpContext context)
        {
            try
            {
                using var scope = _scopeFactory.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IExcepcionLogAppService>();

                var usuario = context.User?.Identity?.Name ?? "Anónimo";
                var ruta = context.Request?.Path.Value;
                var metodo = context.Request?.Method;

                return await service.RegistrarExcepcion(
                    mensaje: e.Message,
                    detalle: e.ToString(),
                    tipoExcepcion: e.GetType().FullName ?? "Exception",
                    ruta: ruta,
                    metodoHttp: metodo,
                    usuario: usuario
                );
            }
            catch (Exception logEx)
            {
                _logger.LogError(logEx, "Error al registrar excepción en base de datos");
                return null;
            }
        }
    }
}
