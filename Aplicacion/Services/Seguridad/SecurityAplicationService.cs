using Aplicacion.Core;
using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using System.Threading.Tasks;
using Aplicacion.Helpers;
using AutoMapper;
using Dominio.Context.Entidades;
using Dominio.Context.Entidades.Seguridad;
using Dominio.Core;
using Dominio.Core.Extensions;
using Dominio.Core.Jwtoken;
using Dominio.Core.Result;
using Infraestructura.Context;
using Infraestructura.Core.Jwtoken;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Aplicacion.Services.Seguridad
{
    public class SecurityAplicationService : BaseDisposable, ISecurityApplicationService
    {
        private readonly IGenericRepository<IDataContext> _genericRepository;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;
        public SecurityAplicationService(IGenericRepository<IDataContext> genericRepository, ITokenService tokenService, IMapper mapper, IOptions<JwtSettings> jwtSettings)
        {
            _genericRepository = genericRepository;
            _tokenService = tokenService;
            _mapper = mapper;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<Result<UsuarioDTO>> EditarUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return await Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            Usuario usuarioExiste = await _genericRepository.GetSingleAsync<Usuario>(r => r.UsuarioId == request.Usuario.UsuarioId);

            if (usuarioExiste.IsNull())
            { 
                return await Task.FromResult(Result<UsuarioDTO>.Failure("El usuario no existe", "USER_NOT_FOUND"));
            }

            if (request.Usuario.EditarContrasena)
            {
                usuarioExiste.Contrasena = PasswordEncryptor.HashPassword(request.Usuario.Contrasena);
            } 

            usuarioExiste.Nombre = request.Usuario.Nombre.ValueOrEmpty();
            usuarioExiste.Apellido = request.Usuario.Apellido.ValueOrEmpty();
            usuarioExiste.RolId = request.Usuario.RolId.ValueOrEmpty();
            usuarioExiste.Activo = request.Usuario.Activo;

            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("EditarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false }; 
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return await Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuarioExiste), "Usuario actualizado exitosamente"));
        }

        public async Task<Result<List<PantallaDTO>>> ObtenerPantallas()
        {
            var pantallas = await _genericRepository.GetAllAsync<Pantalla>();
            var lista = pantallas.Select(r => new PantallaDTO { Descripcion = r.Descripcion, PantallaId = r.PantallaId }).ToList(); 
            return await Task.FromResult(Result<List<PantallaDTO>>.Success(lista));
        }

        public async Task<Result<RolDTO>> EdicionPermisos(EdicionPermisosRequest request)
        {
            var permisos = await _genericRepository.GetFilteredAsync<Permisos>(r => r.RolId == request.RolId);

            foreach (var item in request.Permisos) 
            {
                var permiso = permisos.FirstOrDefault(r => r.PantallaId == item.PantallaId);
                if (permiso.IsNotNull())
                {
                    permiso.Ver = item.Ver;
                    permiso.Editar = item.Editar;
                    permiso.Eliminar = item.Eliminar;

                    if (!permiso.Ver)
                    {
                        _genericRepository.Remove(permiso);
                    }
                }
                else
                {
                    var nuevoPermiso = new Permisos 
                    {
                        Editar = item.Editar,
                        Eliminar = item.Eliminar,
                        PantallaId = item.PantallaId,
                        RolId = item.RolId,
                        Ver = item.Ver,
                    };
                    _genericRepository.Add(nuevoPermiso); 
                }
            }
            
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return await Task.FromResult(Result<RolDTO>.Success(new RolDTO())); 
        }

        public async Task<Result<UsuarioDTO>> CrearUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return await Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            var usuarioRequest = request.Usuario;

            Usuario usuarioExiste = await _genericRepository.GetSingleAsync<Usuario>(r => r.UsuarioId == usuarioRequest.UsuarioId);

            if (usuarioExiste.IsNotNull())
            { 
                return await Task.FromResult(Result<UsuarioDTO>.Failure("Usuario ya esta registrado", "USER_EXISTS"));
            }

            var usuario = new Usuario
            {
                Apellido = usuarioRequest.Apellido.ValueOrEmpty(),
                Contrasena = PasswordEncryptor.HashPassword(usuarioRequest.Contrasena), 
                Nombre = usuarioRequest.Nombre.ValueOrEmpty(),
                RolId = usuarioRequest.RolId.ValueOrEmpty(),
                UsuarioId = usuarioRequest.UsuarioId.ValueOrEmpty(),
                Activo = usuarioRequest.Activo
            };

            _genericRepository.Add(usuario);
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return await Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuario), "Usuario creado exitosamente"));
        }

        public async Task<Result<UsuarioDTO>> IniciarSesion(UserRequest request)
        {
            var includes = new List<string> { "Rol", "Rol.Permisos" };

            if (string.IsNullOrWhiteSpace(request?.Password) || string.IsNullOrWhiteSpace(request?.UsuarioId))
            { 
                return await Task.FromResult(Result<UsuarioDTO>.Unauthorized("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
            }

            Usuario usuario = await _genericRepository.GetSingleAsync<Usuario>(r => r.UsuarioId == request.UsuarioId, includes);

            if (usuario.IsNotNull() && PasswordEncryptor.VerifyPassword(request.Password, usuario.Contrasena))
            {
                if (!usuario.Activo)
                { 
                    return await Task.FromResult(Result<UsuarioDTO>.Unauthorized($"Usuario {usuario.UsuarioId} esta desactivado", "USER_INACTIVE"));
                }

                var newAccessToken = _tokenService.Generate(usuario);
                var newRefreshToken = _tokenService.GenerateRefreshToken();

                usuario.RefreshToken = HashRefreshToken(newRefreshToken);
                usuario.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                if (request.RequestUserInfo != null)
                {
                    request.RequestUserInfo.UsuarioId = usuario.UsuarioId;
                }
                else
                {
                    request.RequestUserInfo = new RequestUserInfo
                    {
                        UsuarioId = usuario.UsuarioId,
                    };
                }

                TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("IniciarSesion");
                _genericRepository.UnitOfWork.Commit(transactionInfo);

                var resultDto = new UsuarioDTO
                {
                    Apellido = usuario.Apellido,
                    Nombre = usuario.Nombre,
                    RolId = usuario.RolId,
                    Token = newAccessToken,
                    RefreshToken = newRefreshToken,
                    UsuarioAutenticado = true,
                    UsuarioId = usuario.UsuarioId,
                    Permisos = MapPermisosDto(usuario.Rol?.Permisos)
                };

                return await Task.FromResult(Result<UsuarioDTO>.Success(resultDto, "Inicio de sesión exitoso"));
            }

            return await Task.FromResult(Result<UsuarioDTO>.Failure("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
        }

        public Task<Result<UsuarioDTO>> RefreshToken(TokenRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.AccessToken) || string.IsNullOrWhiteSpace(request.RefreshToken))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Solicitud de token inválida", "INVALID_TOKEN_REQUEST"));
            }

            ClaimsPrincipal principal;
            try
            {
                principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            } 
            catch (SecurityTokenException)
            {
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de acceso inválido", "INVALID_ACCESS_TOKEN"));
            }

            string? userId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrWhiteSpace(userId))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de acceso inválido", "INVALID_ACCESS_TOKEN"));
            }

            string refreshTokenHash = HashRefreshToken(request.RefreshToken);
            var usuario = _genericRepository.GetSingle<Usuario>(u => u.UsuarioId == userId && u.RefreshToken == refreshTokenHash, ["Rol", "Rol.Permisos"]);

            if (usuario == null || !usuario.Activo || usuario.RefreshTokenExpiryTime <= DateTime.UtcNow)
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de refresco inválido o expirado", "INVALID_REFRESH_TOKEN"));
            }

            var newAccessToken = _tokenService.Generate(usuario);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            usuario.RefreshToken = HashRefreshToken(newRefreshToken);
            usuario.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("RefreshToken")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            var resultDto = new UsuarioDTO 
            {
                Apellido = usuario.Apellido,
                Nombre = usuario.Nombre,
                RolId = usuario.RolId,
                Token = newAccessToken,
                RefreshToken = newRefreshToken,
                UsuarioAutenticado = true,
                UsuarioId = usuario.UsuarioId,
                Permisos = MapPermisosDto(usuario.Rol?.Permisos)
            };

            return Task.FromResult(Result<UsuarioDTO>.Success(resultDto, "Token renovado correctamente"));
        }

        public async Task<Result<SearchResult<UsuarioDTO>>> ObtenerUsuario(GetUserRequest request)
        {
            var queryInfo = request.QueryInfo ?? new QueryInfo();
            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(queryInfo);
            var usuarios = await _genericRepository.GetPagedAndFilteredAsync<Usuario>(dynamicFilter);
            var result = new SearchResult<UsuarioDTO>
            {
                PageCount = usuarios.PageCount,
                ItemCount = usuarios.ItemCount,
                TotalItems = usuarios.TotalItems,
                PageIndex = usuarios.PageIndex,
                Items = [.. (from qry in usuarios.Items as IEnumerable<Usuario> select MapUsuarioDto(qry))],
            };

            return await Task.FromResult(Result<SearchResult<UsuarioDTO>>.Success(result));
        }

        public async Task<Result<RolDTO>> CrearRol(EdicionRolRequest request)
        {
            if (request.Rol.IsNull())
            {
                return await Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = await _genericRepository.GetSingleAsync<Rol>(r => r.RolId == request.Rol.RolId);
            if (rol.IsNotNull())
            {
                return await Task.FromResult(Result<RolDTO>.Failure($"El rol {request.Rol.RolId} ya existe", "ROLE_EXISTS"));
            }

            var nuevoRol = new Rol
            {
                Descripcion = request.Rol.Descripcion,
                RolId = request.Rol.RolId
            };

            _genericRepository.Add(nuevoRol);
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarRol")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return await Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public async Task<Result<RolDTO>> EditarRol(EdicionRolRequest request)
        {
            if (request.Rol is null)
            {
                return await Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = await _genericRepository.GetSingleAsync<Rol>(r => r.RolId == request.Rol.RolId);

            if (rol.IsNull())
            {
                return await Task.FromResult(Result<RolDTO>.Failure($"El Rol {request.Rol.RolId} no existe", "ROLE_NOT_FOUND"));
            }

            rol.Descripcion = request.Rol.Descripcion;
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("EditarRol")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return await Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public async Task<Result<List<RolDTO>>> ObtenerRoles()
        {
            var includes = new List<string> { "Permisos" };
            var roles = await _genericRepository.GetAllAsync<Rol>(includes);
            var lista = roles.Select(qry =>
            new RolDTO
            {
                Descripcion = qry.Descripcion,
                RolId = qry.RolId,
                Permisos = MapPermisosDto(qry?.Permisos),
            }).ToList();

            return await Task.FromResult(Result<List<RolDTO>>.Success(lista));
        }

        private static List<PermisosDTO> MapPermisosDto(List<Permisos>? permisos)
        {
            return permisos?.Select(r => new PermisosDTO
            {
                Editar = r.Editar,
                Eliminar = r.Eliminar,
                PantallaId = r.PantallaId,
                RolId = r.RolId,
                Ver = r.Ver,
            }).ToList() ?? new List<PermisosDTO>();
        }

        private static UsuarioDTO MapUsuarioDto(Usuario qry)
        {
            return new UsuarioDTO
            {
                Apellido = qry.Apellido,
                Nombre = qry.Nombre,
                RolId = qry.RolId,
                UsuarioId = qry.UsuarioId,
                FechaTransaccion = qry.FechaTransaccion,
                Activo = qry.Activo
            };
        }

        private static string HashRefreshToken(string refreshToken)
        {
            var tokenBytes = Encoding.UTF8.GetBytes(refreshToken);
            var hashBytes = SHA256.HashData(tokenBytes);
            return Convert.ToBase64String(hashBytes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_genericRepository.IsNotNull()) _genericRepository.Dispose();

            }

            base.Dispose(disposing);
        }

        public async Task<bool> TienePermisoEditarAsync(string usuarioId, string pantallaId)
        {
            // 1. Validar parámetros de entrada usando tus helpers de extensión
            if (usuarioId.IsMissingValue() || pantallaId.IsMissingValue())
            {
                return false;
            }
            List<string> includes = ["Rol", "Rol.Permisos"];
            // Usamos el nuevo método GetSingleAsync pasando las expresiones lambda de Include
            // Navegamos de Usuario -> Rol e incluyendo los Permisos del Rol
            var usuario = await _genericRepository.GetSingleAsync<Usuario>(
                u => u.UsuarioId == usuarioId, includes);

            // Validamos la existencia y estado activo del usuario
            if (usuario.IsNull() || usuario.EstaDesactivado() || usuario.Rol.IsNull())
            {
                return false;
            }

            // Retorna True únicamente si el registro existe y la propiedad Editar es verdadera
            return usuario.TienePermisoEditar(pantallaId);
        }
    }
}
