using Aplicacion.Core;
using Infraestructura.Context;
using Scalar.AspNetCore;
using WebServices.Extensions;
using WebServices.Jwtoken;
using WebServices.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.ConfigureJwt();

builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(AutoMapperProfile).Assembly));

const string AllowAllOriginsPolicy = "AllowAllOriginsPolicy";
const string AllowSpecificOriginsPolicy = "AllowSpecificOriginsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowAllOriginsPolicy,
        x =>
        {
            x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });

    options.AddPolicy(AllowSpecificOriginsPolicy, policy =>
    {
        var allowedOrigins = builder.Configuration
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? new string[0];

        if (allowedOrigins.Length > 0)
        {
            policy.WithOrigins(allowedOrigins)
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        }
        else
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        }
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

    // Inserta datos iniciales solo si no existen
    DataSeeder.Seed(context);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseCors(app.Environment.IsDevelopment() ? AllowAllOriginsPolicy : AllowSpecificOriginsPolicy);


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
