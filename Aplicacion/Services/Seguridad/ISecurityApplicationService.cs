using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;

namespace Aplicacion.Services.Seguridad
{
    public interface ISecurityApplicationService
    {
        UsuarioDTO EditarUsuario(EdicionUsuarioRequest request);
        List<PantallaDTO> ObtenerPantallas();
        RolDTO EdicionPermisos(EdicionPermisosRequest request);
        UsuarioDTO CrearUsuario(EdicionUsuarioRequest request);
        UsuarioDTO IniciarSesion(UserRequest request);
        UsuarioDTO RefreshToken(TokenRequest request);
        SearchResult<UsuarioDTO> ObtenerUsuario(GetUserRequest request);
        RolDTO CrearRol(EdicionRolRequest request);
        RolDTO EditarRol(EdicionRolRequest request);
        List<RolDTO> ObtenerRoles();
    }
}
