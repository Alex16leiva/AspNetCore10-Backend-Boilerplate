using Aplicacion.DTOs;
using Aplicacion.DTOs.ExcepcionLogDtos;

namespace Aplicacion.Services.ExcepcionLogServices
{
    public interface IExcepcionLogAppService
    {
        Task<SearchResult<ExcepcionLogDTO>> ObtenerExcepcionesPaginado(ExcepcionLogRequest request);
        Task<int> RegistrarExcepcion(string mensaje, string? detalle, string tipoExcepcion, string? ruta, string? metodoHttp, string? usuario);
        Task<ExcepcionLogDTO> MarcarResuelta(ExcepcionLogRequest request);
    }
}
