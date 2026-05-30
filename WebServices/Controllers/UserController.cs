using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using Aplicacion.Services.Seguridad;
using Dominio.Core.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISecurityApplicationService _securityAppService;
        public UserController(ISecurityApplicationService securityAppService)
        {
            _securityAppService = securityAppService;
        }

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserRequest request)
        {
            var usuario = await _securityAppService.IniciarSesion(request);
            return MapResult(usuario);
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest request)
        {
            var usuario = await _securityAppService.RefreshToken(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("crear-usuario")]
        public async Task<IActionResult> CreateUser(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.CrearUsuario(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("editar-usuario")]
        public async Task<IActionResult> EditarUsuario(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.EditarUsuario(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("obtener-usuarios")]
        public async Task<IActionResult> ObtenerUsuarios(GetUserRequest request)
        {
            var usuarios = await _securityAppService.ObtenerUsuario(request);
            return MapResult(usuarios);
        }

        [Authorize]
        [HttpGet("obtener-roles")]
        public async Task<IActionResult> ObtenerRoles()
        {
            var roles = await _securityAppService.ObtenerRoles();
            return MapResult(roles);
        }

        [Authorize]
        [HttpPost("crear-rol")]
        public async Task<IActionResult> CrearRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.CrearRol(request);
            return MapResult(rol);
        }

        [Authorize]
        [HttpPost("editar-rol")]
        public async Task<IActionResult> EditarRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.EditarRol(request);
            return MapResult(rol);
        }

        [Authorize]
        [HttpGet("obtener-pantalla")]
        public async Task<IActionResult> ObtenerPantalla()
        {
            var pantallas = await _securityAppService.ObtenerPantallas();
            return MapResult(pantallas);
        }

        [Authorize]
        [HttpPost("edicion-permisos")]
        public async Task<IActionResult> EdicionPermisos(EdicionPermisosRequest request)
        {
            var rol = await _securityAppService.EdicionPermisos(request);
            return MapResult(rol);
        }

        private IActionResult MapResult<T>(Result<T> result)
        {
            if (result == null) return StatusCode(500);

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return result.Status switch
            {
                ResultStatus.ValidationError => BadRequest(result),
                ResultStatus.ApplicationError => Conflict(result),
                ResultStatus.Exception => StatusCode(500, result),
                _ => BadRequest(result),
            };
        }
    }
}
