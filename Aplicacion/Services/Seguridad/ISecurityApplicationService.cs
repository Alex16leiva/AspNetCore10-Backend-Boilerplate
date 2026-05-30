using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using Dominio.Core.Result;

namespace Aplicacion.Services.Seguridad
{
    public interface ISecurityApplicationService
    {
        Task<Result<UsuarioDTO>> EditarUsuario(EdicionUsuarioRequest request);
        Task<Result<List<PantallaDTO>>> ObtenerPantallas();
        Task<Result<RolDTO>> EdicionPermisos(EdicionPermisosRequest request);
        Task<Result<UsuarioDTO>> CrearUsuario(EdicionUsuarioRequest request);
        Task<Result<UsuarioDTO>> IniciarSesion(UserRequest request);
        Task<Result<UsuarioDTO>> RefreshToken(TokenRequest request);
        Task<Result<SearchResult<UsuarioDTO>>> ObtenerUsuario(GetUserRequest request);
        Task<Result<RolDTO>> CrearRol(EdicionRolRequest request);
        Task<Result<RolDTO>> EditarRol(EdicionRolRequest request);
        Task<Result<List<RolDTO>>> ObtenerRoles();
    }
}
