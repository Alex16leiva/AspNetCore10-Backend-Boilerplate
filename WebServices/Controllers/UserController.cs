using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using Aplicacion.Services.Seguridad;
using Dominio.Core.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

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
        [EnableRateLimiting("AuthPolicy")]
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserRequest request)
        {
            var usuario = await _securityAppService.IniciarSesion(request);
            return Ok(usuario);
        }

        [AllowAnonymous]
        [EnableRateLimiting("AuthPolicy")]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest request)
        {
            var usuario = await _securityAppService.RefreshToken(request);
            return Ok(usuario);
        }

        [Authorize]
        [HttpPost("crear-usuario")]
        public async Task<IActionResult> CreateUser(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.CrearUsuario(request);
            return Ok(usuario);
        }

        [Authorize]
        [HttpPost("editar-usuario")]
        public async Task<IActionResult> EditarUsuario(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.EditarUsuario(request);
            return Ok(usuario);
        }

        [Authorize]
        [HttpPost("obtener-usuarios")]
        public async Task<IActionResult> ObtenerUsuarios(GetUserRequest request)
        {
            var usuarios = await _securityAppService.ObtenerUsuario(request);
            return Ok(usuarios);
        }

        [Authorize]
        [HttpGet("obtener-roles")]
        public async Task<IActionResult> ObtenerRoles()
        {
            var roles = await _securityAppService.ObtenerRoles();
            return Ok(roles);
        }

        [Authorize]
        [HttpPost("crear-rol")]
        public async Task<IActionResult> CrearRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.CrearRol(request);
            return Ok(rol);
        }

        [Authorize]
        [HttpPost("editar-rol")]
        public async Task<IActionResult> EditarRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.EditarRol(request);
            return Ok(rol);
        }

        [Authorize]
        [HttpGet("obtener-pantalla")]
        public async Task<IActionResult> ObtenerPantalla()
        {
            var pantallas = await _securityAppService.ObtenerPantallas();
            return Ok(pantallas);
        }

        [Authorize]
        [HttpPost("edicion-permisos")]
        public async Task<IActionResult> EdicionPermisos(EdicionPermisosRequest request)
        {
            var rol = await _securityAppService.EdicionPermisos(request);
            return Ok(rol);
        }
    }
}
