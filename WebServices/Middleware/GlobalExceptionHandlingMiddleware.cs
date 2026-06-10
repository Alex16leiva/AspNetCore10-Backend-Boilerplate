using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WebServices.Middleware
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public GlobalExceptionHandlingMiddleware(
            ILogger<GlobalExceptionHandlingMiddleware> logger,
            IWebHostEnvironment env,
            IConfiguration configuration)
        {
            _logger = logger;
            _env = env;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (context.Response.HasStarted)
            {
                _logger.LogWarning("The response has already started, the global exception middleware will not write the response (TraceId: {TraceId}).", context.TraceIdentifier);
                throw exception;
            }

            var traceId = Activity.Current?.Id ?? context.TraceIdentifier;

            int statusCode = StatusCodes.Status500InternalServerError;
            string title = "An error occurred while processing your request.";
            object? errors = null;

            if (exception is ValidationException fvEx)
            {
                statusCode = StatusCodes.Status400BadRequest;
                title = "One or more validation errors occurred.";

                var errorDict = fvEx.Errors
                    .GroupBy(e => e.PropertyName)
                    .ToDictionary(g => g.Key, g => g.Select(x => x.ErrorMessage).ToArray());

                errors = errorDict;
            }
            else if (exception is JsonException jsonEx)
            {
                statusCode = StatusCodes.Status400BadRequest;
                title = "Malformed JSON payload.";
                errors = new { message = jsonEx.Message };
            }
            else if (exception is OperationCanceledException || exception is TaskCanceledException)
            {
                statusCode = StatusCodes.Status499ClientClosedRequest; // non-standard - client closed
                title = "Request was cancelled.";
            }

            bool includeExceptionDetails = _env.IsDevelopment() || _configuration.GetValue<bool?>("ApiSettings:IncludeExceptionDetails") == true;

            var problem = new ProblemDetails
            {
                Type = $"https://httpstatuses.com/{statusCode}",
                Title = title,
                Status = statusCode,
                Instance = context.Request.Path
            };

            var payload = new Dictionary<string, object?>
            {
                ["type"] = problem.Type,
                ["title"] = problem.Title,
                ["status"] = problem.Status,
                ["instance"] = problem.Instance,
                ["traceId"] = traceId,
                ["timestampUtc"] = DateTime.UtcNow
            };

            if (errors != null)
            {
                payload["errors"] = errors;
            }

            if (includeExceptionDetails)
            {
                payload["detail"] = exception.ToString();
            }

            _logger.LogError(exception, "Unhandled exception occurred while processing request {Method} {Path} (TraceId: {TraceId})",
                context.Request?.Method, context.Request?.Path, traceId);

            context.Response.Clear();
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/problem+json";

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(payload, options));
        }
    }
}
