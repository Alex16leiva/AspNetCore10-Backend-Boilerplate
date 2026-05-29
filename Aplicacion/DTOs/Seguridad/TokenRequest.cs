namespace Aplicacion.DTOs.Seguridad
{
    public class TokenRequest
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
