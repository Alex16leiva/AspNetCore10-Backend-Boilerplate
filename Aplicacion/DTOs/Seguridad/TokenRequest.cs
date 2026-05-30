namespace Aplicacion.DTOs.Seguridad
{
    public class TokenRequest : RequestBase
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
