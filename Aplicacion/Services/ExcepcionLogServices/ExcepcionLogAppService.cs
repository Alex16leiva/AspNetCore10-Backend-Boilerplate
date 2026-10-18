using Aplicacion.DTOs;
using Aplicacion.DTOs.ExcepcionLogDtos;
using Aplicacion.Helpers;
using Aplicacion.Services.Seguridad;
using Dominio.Context.Entidades.ExcepcionLogAgg;
using Dominio.Core;
using Dominio.Core.Extensions;
using Infraestructura.Context;

namespace Aplicacion.Services.ExcepcionLogServices
{
    public class ExcepcionLogAppService : IExcepcionLogAppService
    {
        private readonly IGenericRepository<IDataContext> _genericRepository;
        private readonly ISecurityApplicationService _securityAplicationService;

        public ExcepcionLogAppService(IGenericRepository<IDataContext> genericRepository, ISecurityApplicationService securityAplicationService)
        {
            _genericRepository = genericRepository;
            _securityAplicationService = securityAplicationService;
        }

        public async Task<SearchResult<ExcepcionLogDTO>> ObtenerExcepcionesPaginado(ExcepcionLogRequest request)
        {
            if (request.IsNull())
            {
                throw new ArgumentNullException(nameof(request));
            }

            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(request.QueryInfo ?? new QueryInfo());
            var result = await _genericRepository.GetPagedAndFilteredAsync<ExcepcionLog>(dynamicFilter);
            return new SearchResult<ExcepcionLogDTO>
            {
                PageCount = result.PageCount,
                ItemCount = result.ItemCount,
                TotalItems = result.TotalItems,
                PageIndex = result.PageIndex,
                Items = (from q in result.Items as IEnumerable<ExcepcionLog> select MapDto(q)).ToList(),
            };
        }

        public async Task<int> RegistrarExcepcion(string mensaje, string? detalle, string tipoExcepcion, string? ruta, string? metodoHttp, string? usuario)
        {
            var entidad = new ExcepcionLog
            {
                Mensaje = mensaje.Length > 4000 ? mensaje[..4000] : mensaje,
                Detalle = detalle,
                TipoExcepcion = tipoExcepcion.Length > 500 ? tipoExcepcion[..500] : tipoExcepcion,
                Ruta = ruta,
                MetodoHttp = metodoHttp,
                Usuario = usuario,
                Resuelta = false,
            };

            await _genericRepository.AddAsync(entidad);

            var transactionInfo = new TransactionInfo
            {
                ModificadoPor = "Sistema",
                TipoTransaccion = "RegistrarExcepcion",
                DescripcionTransaccion = "Excepcion",
            };
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return entidad.Id;
        }

        public async Task<ExcepcionLogDTO> MarcarResuelta(ExcepcionLogRequest request)
        {
            if (request.IsNull()) throw new ArgumentNullException(nameof(request));

            if (request.RequestUserInfo.IsNull()) throw new ArgumentNullException(nameof(request.RequestUserInfo));

            var usuarioId = request.RequestUserInfo?.UsuarioId;
            if (string.IsNullOrWhiteSpace(usuarioId))
                return new ExcepcionLogDTO { Message = "El usuario no está identificado." };

            bool tienePermiso = await _securityAplicationService.TienePermisoEditarAsync(usuarioId, "ExcepcionLog");
            if (!tienePermiso)
                return new ExcepcionLogDTO { Message = "Operación denegada: El usuario no cuenta con permisos de edición para el módulo de ExcepcionLog." };

            if (request.ExcepcionLog.IsNull() || request.ExcepcionLog.Id <= 0)
                return new ExcepcionLogDTO { Message = "El Id de la excepción es inválido." };

            var entidad = await _genericRepository.GetSingleAsync<ExcepcionLog>(x => x.Id == request.ExcepcionLog!.Id);
            if (entidad == null)
                return new ExcepcionLogDTO { Message = "No se encontró el registro." };

            entidad.Resuelta = true;

            var transactionInfo = TransactionInfoHelper.CrearTransactionInfo(request.RequestUserInfo!, "MarcarExcepcionResuelta");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return MapDto(entidad);
        }

        private static ExcepcionLogDTO MapDto(ExcepcionLog q) => new()
        {
            Id = q.Id,
            Mensaje = q.Mensaje,
            Detalle = q.Detalle,
            TipoExcepcion = q.TipoExcepcion,
            Ruta = q.Ruta,
            MetodoHttp = q.MetodoHttp,
            Usuario = q.Usuario,
            Resuelta = q.Resuelta,
            FechaRegistro = q.FechaTransaccion,
        };
    }
}
