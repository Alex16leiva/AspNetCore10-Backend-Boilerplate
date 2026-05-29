using Dominio.Context.Entidades.Seguridad;

namespace Infraestructura.Core.Jwtoken
{
    public interface ITokenService
    {
        string Generate(Usuario user);
        string GenerateRefreshToken();
        System.Security.Claims.ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
