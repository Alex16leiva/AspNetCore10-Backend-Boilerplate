namespace Aplicacion.DTOs.ExcepcionLogDtos
{
    public class ExcepcionLogDTO
    {
        public int Id { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string? Detalle { get; set; }
        public string TipoExcepcion { get; set; } = string.Empty;
        public string? Ruta { get; set; }
        public string? MetodoHttp { get; set; }
        public string? Usuario { get; set; }
        public bool Resuelta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string? Message { get; set; }
    }

    public class ExcepcionLogRequest
    {
        public ExcepcionLogDTO? ExcepcionLog { get; set; }
        public QueryInfo? QueryInfo { get; set; }
        public RequestUserInfo? RequestUserInfo { get; set; }
    }
}
