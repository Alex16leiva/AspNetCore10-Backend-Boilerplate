using Aplicacion.Core;
using Aplicacion.Services.ConfiguracionesApp;
using Aplicacion.Services.Seguridad;
using CrossCutting.Configuration;
using Infraestructura.Context;
using Infraestructura.Core.Jwtoken;
using Infraestructura.Core.RestClient;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Extensions
{
    public static class DependencyInjectionRepository
    {
        public static IServiceCollection AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("conectionDataBase");

            // Inicialización única de configuraciones
            AppSettingsManager.Initialize(connectionString);

            services.AddDbContext<MyContext>(dbContextOption =>
                dbContextOption.UseSqlServer(connectionString)
            );

            services.AddScoped<IDataContext, MyContext>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Servicios de Aplicación
            services.AddScoped<SecurityAplicationService>();
            services.AddScoped<IConfiguracionesApplicationService, ConfiguracionesApplicationService>();

            return services;
        }

        public static IServiceCollection AddExternalAndSecurityServices(this IServiceCollection services)
        {
            // JWT
            services.AddTransient<ITokenService, JwtTokenService>();

            // Rest Client
            RestClientFactory.SetCurrent(new HttpRestClientFactory());
            //services.AddTransient<IRestClient, HttpRestClient>();
            //services.AddTransient<IRestClientFactory, HttpRestClientFactory>();

            return services;
        }
    }
}