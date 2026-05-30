using Aplicacion.DTOs.ConfiguracionesDTO;
using Aplicacion.Services.ConfiguracionesApp;
using Dominio.Core.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracionesController : ControllerBase
    {
        private readonly IConfiguracionesApplicationService _configuracionesAppService;

        public ConfiguracionesController(IConfiguracionesApplicationService configuracionesAppService)
        {
            _configuracionesAppService = configuracionesAppService;
        }

        [HttpPost("crear-configuracion")]
        public async Task<IActionResult> CrearConfiguracion(ConfiguracionesRequest request)
        {
            var configuracion = await _configuracionesAppService.CrearConfiguracion(request);
            return MapResult(configuracion);
        }

        [HttpPost("obtener-configuraciones")]
        public async Task<IActionResult> GetConfiguraciones(ConfiguracionesRequest request)
        {
            var configuraciones = await _configuracionesAppService.ObtenerConfiguracionesPaginado(request);
            return MapResult(configuraciones);
        }

        [HttpPost("crear-configuracion-detalle")]
        public async Task<IActionResult> CrearConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var configuracionesDetalle = await _configuracionesAppService.CrearConfiguracionDetalle(request);
            return MapResult(configuracionesDetalle);
        }

        [HttpPost("editar-configuracion-detalle")]
        public async Task<IActionResult> EditarConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var configuracionesDetalle = await _configuracionesAppService.EditarConfiguracionesDetalle(request);
            return MapResult(configuracionesDetalle);
        }

        [HttpPost("editar-configuracion")]
        public async Task<IActionResult> EditarConfiguracion(ConfiguracionesRequest request)
        {
            var configuracion = await _configuracionesAppService.EditarConfiguracion(request);
            return MapResult(configuracion);
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
