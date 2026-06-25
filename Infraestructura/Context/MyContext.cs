using Dominio.Context.Entidades.ConfiguracionesAgg;
using Dominio.Context.Entidades.ExcepcionLogAgg;
using Dominio.Context.Entidades.Seguridad;
using Dominio.Core;
using Dominio.Core.Extensions;
using Infraestructura.Context.Mapping.ConfiguracionesMap;
using Infraestructura.Context.Mapping.ExcepcionLogMaps;
using Infraestructura.Context.Mapping.Seguridad;
using Infraestructura.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infraestructura.Context
{
    public class MyContext : BCUnitOfWork, IDataContext
    {
        private const int DefaultCommandTimeoutSeconds = 30;

        public MyContext(DbContextOptions<MyContext> context, IConfiguration configuration)
            : base(context)
        {
            int commandTimeoutSeconds = DefaultCommandTimeoutSeconds;

            if (configuration != null)
            {
                var configuredTimeout = configuration["DatabaseSettings:CommandTimeoutSeconds"];
                if (!string.IsNullOrWhiteSpace(configuredTimeout)
                    && int.TryParse(configuredTimeout, out var parsedTimeout)
                    && parsedTimeout > 0)
                {
                    commandTimeoutSeconds = parsedTimeout;
                }
            }

            Database.SetCommandTimeout(commandTimeoutSeconds);
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Rol {  get; set; }
        public virtual DbSet<Pantalla> Pantalla { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Configuraciones> Configuraciones { get; set; }
        public virtual DbSet<ConfiguracionesDetalle> ConfiguracionesDetalle { get; set; }
        public virtual DbSet<ExcepcionLog> ExcepcionLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new PantallaMap());
            modelBuilder.ApplyConfiguration(new PermisosMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionesMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionesDetalleMap());
            modelBuilder.ApplyConfiguration(new ExcepcionLogMap());
            base.OnModelCreating(modelBuilder);
        }


        public override void Commit(TransactionInfo? transactionInfo)
        {
            base.Commit(transactionInfo);
        }
    }
}
