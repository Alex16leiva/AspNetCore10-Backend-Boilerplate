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

        public Task<Result<UsuarioDTO>> EditarUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            Usuario usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.Usuario.UsuarioId);

            if (usuarioExiste.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("El usuario no existe", "USER_NOT_FOUND"));
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

            return Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuarioExiste), "Usuario actualizado exitosamente"));
        }

        public Task<Result<List<PantallaDTO>>> ObtenerPantallas()
        {
            var pantallas = _genericRepository.GetAll<Pantalla>();
            var lista = pantallas.Select(r => new PantallaDTO { Descripcion = r.Descripcion, PantallaId = r.PantallaId }).ToList(); 
            return Task.FromResult(Result<List<PantallaDTO>>.Success(lista));
        }

        public Task<Result<RolDTO>> EdicionPermisos(EdicionPermisosRequest request)
        {
            var permisos = _genericRepository.GetFiltered<Permisos>(r => r.RolId == request.RolId);

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
            return Task.FromResult(Result<RolDTO>.Success(new RolDTO())); 
        }

        public Task<Result<UsuarioDTO>> CrearUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            var usuarioRequest = request.Usuario;

            Usuario usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == usuarioRequest.UsuarioId);

            if (usuarioExiste.IsNotNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario ya esta registrado", "USER_EXISTS"));
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
            return Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuario), "Usuario creado exitosamente"));
        }

        public Task<Result<UsuarioDTO>> IniciarSesion(UserRequest request)
        {
            var includes = new List<string> { "Rol", "Rol.Permisos" };

            if (string.IsNullOrWhiteSpace(request?.Password) || string.IsNullOrWhiteSpace(request?.UsuarioId))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
            }

            Usuario usuario = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.UsuarioId, includes);

            if (usuario.IsNotNull() && PasswordEncryptor.VerifyPassword(request.Password, usuario.Contrasena))
            {
                if (!usuario.Activo)
                { 
                    return Task.FromResult(Result<UsuarioDTO>.Failure($"Usuario {usuario.UsuarioId} esta desactivado", "USER_INACTIVE"));
                }

                var newAccessToken = _tokenService.Generate(usuario);
                var newRefreshToken = _tokenService.GenerateRefreshToken();

                usuario.RefreshToken = HashRefreshToken(newRefreshToken);
                usuario.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                if (request.RequestUserInfo != null)
                {
                    request.RequestUserInfo.UsuarioId = usuario.UsuarioId;
                }

                TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("IniciarSesion")
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

                return Task.FromResult(Result<UsuarioDTO>.Success(resultDto, "Inicio de sesión exitoso"));
            }

            return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
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
            var usuario = _genericRepository.GetSingle<Usuario>(u => u.UsuarioId == userId && u.RefreshToken == refreshTokenHash, new List<string> { "Rol", "Rol.Permisos" });

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

        public Task<Result<SearchResult<UsuarioDTO>>> ObtenerUsuario(GetUserRequest request)
        {
            var queryInfo = request.QueryInfo ?? new QueryInfo();
            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(queryInfo);
            var usuarios = _genericRepository.GetPagedAndFiltered<Usuario>(dynamicFilter);
            var result = new SearchResult<UsuarioDTO>
            {
                PageCount = usuarios.PageCount,
                ItemCount = usuarios.ItemCount,
                TotalItems = usuarios.TotalItems,
                PageIndex = usuarios.PageIndex,
                Items = (from qry in usuarios.Items as IEnumerable<Usuario> select MapUsuarioDto(qry)).ToList(),
            };

            return Task.FromResult(Result<SearchResult<UsuarioDTO>>.Success(result));
        }

        public Task<Result<RolDTO>> CrearRol(EdicionRolRequest request)
        {
            if (request.Rol is null)
            {
                return Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = _genericRepository.GetSingle<Rol>(r => r.RolId == request.Rol.RolId);
            if (rol.IsNotNull())
            {
                return Task.FromResult(Result<RolDTO>.Failure($"El rol {request.Rol.RolId} ya existe", "ROLE_EXISTS"));
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

            return Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public Task<Result<RolDTO>> EditarRol(EdicionRolRequest request)
        {
            if (request.Rol is null)
            {
                return Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = _genericRepository.GetSingle<Rol>(r => r.RolId == request.Rol.RolId);

            if (rol.IsNull())
            {
                return Task.FromResult(Result<RolDTO>.Failure($"El Rol {request.Rol.RolId} no existe", "ROLE_NOT_FOUND"));
            }

            rol.Descripcion = request.Rol.Descripcion;
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("EditarRol")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public Task<Result<List<RolDTO>>> ObtenerRoles()
        {
            var includes = new List<string> { "Permisos" };
            var roles = _genericRepository.GetAll<Rol>(includes);
            var lista = roles.Select(qry =>
            new RolDTO
            {
                Descripcion = qry.Descripcion,
                RolId = qry.RolId,
                Permisos = MapPermisosDto(qry?.Permisos),
            }).ToList();

            return Task.FromResult(Result<List<RolDTO>>.Success(lista));
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
    }
}
