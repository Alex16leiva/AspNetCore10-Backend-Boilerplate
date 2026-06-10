using Dominio.Core.Extensions;

namespace Aplicacion.DTOs
{
    public abstract class ResponseBase
    {
        public DateTime? FechaTransaccion { get; set; }
    }
}
