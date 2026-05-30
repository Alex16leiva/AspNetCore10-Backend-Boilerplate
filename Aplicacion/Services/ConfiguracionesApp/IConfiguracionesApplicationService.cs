using Aplicacion.DTOs;
using Aplicacion.DTOs.ConfiguracionesDTO;
using Dominio.Core.Result;

namespace Aplicacion.Services.ConfiguracionesApp
{
    public interface IConfiguracionesApplicationService
    {
        Task<Result<SearchResult<ConfiguracionesDTO>>> ObtenerConfiguracionesPaginado(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDTO>> CrearConfiguracion(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDTO>> EditarConfiguracion(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDetalleDTO>> CrearConfiguracionDetalle(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDetalleDTO>> EditarConfiguracionesDetalle(ConfiguracionesRequest request);
    }
}
