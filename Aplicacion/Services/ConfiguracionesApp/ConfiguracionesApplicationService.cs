using Aplicacion.DTOs;
using Aplicacion.DTOs.ConfiguracionesDTO;
using Aplicacion.Helpers;
using Dominio.Context.Entidades.ConfiguracionesAgg;
using Dominio.Core;
using Dominio.Core.Extensions;
using Dominio.Core.Result;
using Infraestructura.Context;

namespace Aplicacion.Services.ConfiguracionesApp
{
    public class ConfiguracionesApplicationService : IConfiguracionesApplicationService
    {
        private readonly IGenericRepository<IDataContext> _genericRepository;

        public ConfiguracionesApplicationService(IGenericRepository<IDataContext> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Result<ConfiguracionesDTO>> CrearConfiguracion(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var configuracionRequest = request.Configuraciones!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == configuracionRequest.ConfiguracionId);
            if (existingConfiguracion.IsNotNull())
            {
                return Result<ConfiguracionesDTO>.Failure($"Ya existe una configuracion con el ID {existingConfiguracion.ConfiguracionId}", "CONFIGURATION_EXISTS");
            }

            var configuracion = new Configuraciones
            {
                ConfiguracionId = configuracionRequest.ConfiguracionId,
                Descripcion = configuracionRequest.Descripcion
            };

            await _genericRepository.AddAsync(configuracion);
            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("CrearConfiguracion");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDTO>.Success(MapConfiguracionesDTO(configuracion), "Configuracion creada exitosamente");
        }

        public async Task<Result<ConfiguracionesDetalleDTO>> EditarConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionDetalleRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var detalleRequest = request.ConfiguracionesDetalle!;
            var existingConfiguracionDetalle = await _genericRepository.GetSingleAsync<ConfiguracionesDetalle>(x => x.ConfiguracionId == detalleRequest.ConfiguracionId && x.Atributo == detalleRequest.Atributo);
            if (existingConfiguracionDetalle.IsNull())
            {
                return Result<ConfiguracionesDetalleDTO>.Failure($"No existe un detalle de configuracion con el ID {detalleRequest.ConfiguracionId} y el atributo {detalleRequest.Atributo}", "CONFIGURATION_DETAIL_NOT_FOUND");
            }

            existingConfiguracionDetalle.Descripcion = detalleRequest.Descripcion;
            existingConfiguracionDetalle.Valor = detalleRequest.Valor;

            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("EditarConfiguracionDetalle");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDetalleDTO>.Success(MapConfiguracionesDetalleDTO(existingConfiguracionDetalle), "Detalle de configuracion actualizado exitosamente");
        }

        public async Task<Result<ConfiguracionesDTO>> EditarConfiguracion(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var configuracionRequest = request.Configuraciones!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == configuracionRequest.ConfiguracionId);
            if (existingConfiguracion.IsNull())
            {
                return Result<ConfiguracionesDTO>.Failure($"No existe una configuracion con el ID {configuracionRequest.ConfiguracionId}", "CONFIGURATION_NOT_FOUND");
            }

            existingConfiguracion.Descripcion = configuracionRequest.Descripcion;

            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("EditarConfiguracion");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDTO>.Success(MapConfiguracionesDTO(existingConfiguracion), "Configuracion actualizada exitosamente");
        }

        public async Task<Result<ConfiguracionesDetalleDTO>> CrearConfiguracionDetalle(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionDetalleRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var detalleRequest = request.ConfiguracionesDetalle!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == detalleRequest.ConfiguracionId);
            if (existingConfiguracion.IsNull())
            {
                return Result<ConfiguracionesDetalleDTO>.Failure($"La configuracion con el ID {detalleRequest.ConfiguracionId} no existe", "CONFIGURATION_NOT_FOUND");
            }

            var configuracionesDetalle = new ConfiguracionesDetalle
            {
                ConfiguracionId = detalleRequest.ConfiguracionId,
                Atributo = detalleRequest.Atributo,
                Descripcion = detalleRequest.Descripcion,
                Valor = detalleRequest.Valor,
            };

            await _genericRepository.AddAsync(configuracionesDetalle);
            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("CrearConfiguracionDetalle");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDetalleDTO>.Success(MapConfiguracionesDetalleDTO(configuracionesDetalle), "Detalle de configuracion creado exitosamente");
        }

        public async Task<Result<SearchResult<ConfiguracionesDTO>>> ObtenerConfiguracionesPaginado(ConfiguracionesRequest request)
        {
            if (request is null)
            {
                return Result<SearchResult<ConfiguracionesDTO>>.Failure("Solicitud es obligatoria", "NULL_REQUEST", ResultStatus.ValidationError);
            }

            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(request.QueryInfo);
            var configuraciones = await _genericRepository.GetPagedAndFilteredAsync<Configuraciones>(dynamicFilter);
            var result = new SearchResult<ConfiguracionesDTO>
            {
                ItemCount = configuraciones.ItemCount,
                PageCount = configuraciones.PageCount,
                PageIndex = configuraciones.PageIndex,
                TotalItems = configuraciones.TotalItems,
                Items = (from query in configuraciones.Items as IEnumerable<Configuraciones> select MapConfiguracionesDTO(query)).ToList()
            };

            return Result<SearchResult<ConfiguracionesDTO>>.Success(result);
        }

        private static Result<ConfiguracionesDTO>? ValidateConfiguracionRequest(ConfiguracionesRequest request)
        {
            if (request is null || request.Configuraciones is null)
            {
                return Result<ConfiguracionesDTO>.Failure("Configuracion es obligatoria", "NULL_CONFIGURACION", ResultStatus.ValidationError);
            }

            if (request.RequestUserInfo is null)
            {
                return Result<ConfiguracionesDTO>.Failure("Informacion de usuario es obligatoria", "NULL_REQUEST_USER_INFO", ResultStatus.ValidationError);
            }

            return null;
        }

        private static Result<ConfiguracionesDetalleDTO>? ValidateConfiguracionDetalleRequest(ConfiguracionesRequest request)
        {
            if (request is null || request.ConfiguracionesDetalle is null)
            {
                return Result<ConfiguracionesDetalleDTO>.Failure("Detalle de configuracion es obligatorio", "NULL_CONFIGURACION_DETALLE", ResultStatus.ValidationError);
            }

            if (request.RequestUserInfo is null)
            {
                return Result<ConfiguracionesDetalleDTO>.Failure("Informacion de usuario es obligatoria", "NULL_REQUEST_USER_INFO", ResultStatus.ValidationError);
            }

            return null;
        }

        private static ConfiguracionesDetalleDTO MapConfiguracionesDetalleDTO(ConfiguracionesDetalle configuracionesDetalle)
        {
            return new ConfiguracionesDetalleDTO
            {
                ConfiguracionId = configuracionesDetalle.ConfiguracionId,
                Atributo = configuracionesDetalle.Atributo,
                Descripcion = configuracionesDetalle.Descripcion,
                Valor = configuracionesDetalle.Valor,
            };
        }

        private static ConfiguracionesDTO MapConfiguracionesDTO(Configuraciones query)
        {
            return new ConfiguracionesDTO
            {
                ConfiguracionId = query.ConfiguracionId,
                Descripcion = query.Descripcion,
                ConfiguracionesDetalle = query.ConfiguracionesDetalle?
                    .Select(detalle => MapConfiguracionesDetalleDTO(detalle))
                    .ToList() ?? new List<ConfiguracionesDetalleDTO>()
            };
        }
    }
}
