using Dominio.Context.Entidades.ExcepcionLogAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.ExcepcionLogMaps
{
    internal class ExcepcionLogMap : EntityMap<ExcepcionLog>
    {
        public override void Configure(EntityTypeBuilder<ExcepcionLog> builder)
        {
            builder.ToTable("ExcepcionLog");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Mensaje).HasColumnName("Mensaje").HasMaxLength(4000).IsRequired();
            builder.Property(x => x.Detalle).HasColumnName("Detalle").HasColumnType("nvarchar(MAX)").IsRequired(false);
            builder.Property(x => x.TipoExcepcion).HasColumnName("TipoExcepcion").HasMaxLength(500).IsRequired();
            builder.Property(x => x.Ruta).HasColumnName("Ruta").HasMaxLength(2000).IsRequired(false);
            builder.Property(x => x.MetodoHttp).HasColumnName("MetodoHttp").HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.Usuario).HasColumnName("Usuario").HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Resuelta).HasColumnName("Resuelta").HasDefaultValue(false);

            base.Configure(builder);
        }
    }
}
