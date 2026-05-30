using Aplicacion.Core;
using Infraestructura.Context;
using Scalar.AspNetCore;
using WebServices.Extensions;
using WebServices.Jwtoken;
using WebServices.Middleware;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.ConfigureJwt();

builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(AutoMapperProfile).Assembly));

// FluentValidation: register automatic validation and scan for validators in Aplicacion assembly
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(typeof(Aplicacion.Services.Seguridad.Validators.UsuarioDTOValidator).Assembly);

const string AllowSpecificOriginsPolicy = "AllowSpecificOriginsPolicy";
const string AuthRateLimitPolicy = "AuthPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowSpecificOriginsPolicy, policy =>
    {
        var allowedOrigins = builder.Configuration
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? new string[0];

        if (allowedOrigins.Length == 0)
        {
            throw new InvalidOperationException("Cors:AllowedOrigins must be configured.");
        }

        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    options.AddFixedWindowLimiter(AuthRateLimitPolicy, limiterOptions =>
    {
        limiterOptions.PermitLimit = 5;
        limiterOptions.Window = TimeSpan.FromMinutes(1);
        limiterOptions.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        limiterOptions.QueueLimit = 0;
    });
});

builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddApplicationServices();          
builder.Services.AddExternalAndSecurityServices();

builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();

var app = builder.Build();

// 🔹 Seeder: insertar datos iniciales
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MyContext>();

    // Inserta datos iniciales solo si no existen. El usuario admin requiere contraseña configurada.
    DataSeeder.Seed(context, app.Configuration["Seed:AdminPassword"]);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.UseCors(AllowSpecificOriginsPolicy);
app.UseRateLimiter();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
