using Dominio.Core;

namespace Dominio.Context.Entidades.ExcepcionLogAgg
{
    public class ExcepcionLog : Entity
    {
        public int Id { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string? Detalle { get; set; }
        public string TipoExcepcion { get; set; } = string.Empty;
        public string? Ruta { get; set; }
        public string? MetodoHttp { get; set; }
        public string? Usuario { get; set; }
        public bool Resuelta { get; set; }
    }
}
