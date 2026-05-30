using Dominio.Core.Result;

namespace Aplicacion.Services.Seguridad.Examples
{
    /// <summary>
    /// Ejemplos de cómo refactorizar los métodos del SecurityAplicationService
    /// para utilizar el Patrón Result en lugar de retornar DTOs con propiedades de mensaje.
    /// 
    /// Este archivo documenta el patrón y NO debe ser incluido en la compilación final.
    /// Sirve como referencia durante la migración gradual del código.
    /// </summary>
    public class ResultPatternExamples
    {
        /*
        EJEMPLO 1: Método que devuelve éxito o fallo simple
        =====================================================
        
        // ANTES (usando DTO con propiedades de mensaje):
        public UsuarioDTO IniciarSesion(UserRequest request)
        {
            if (usuario.IsNotNull() && PasswordEncryptor.VerifyPassword(request?.Password, usuario.Contrasena))
            {
                return new UsuarioDTO { ... Token = newAccessToken, ... UsuarioAutenticado = true };
            }
            return new UsuarioDTO { Message = "Usuario o Contraseña no valido", UsuarioAutenticado = false };
        }
        
        // DESPUÉS (usando Result<T>):
        public Result<UsuarioDTO> IniciarSesion(UserRequest request)
        {
            if (usuario == null)
            {
                return Result<UsuarioDTO>.Failure("Usuario no encontrado", "USER_NOT_FOUND");
            }
            
            if (!PasswordEncryptor.VerifyPassword(request?.Password, usuario.Contrasena))
            {
                return Result<UsuarioDTO>.Failure("Contraseña incorrecta", "INVALID_PASSWORD");
            }
            
            var usuarioDto = new UsuarioDTO { ... Token = newAccessToken, ... };
            return Result<UsuarioDTO>.Success(usuarioDto, "Sesión iniciada correctamente");
        }
        
        // USO EN CONTROLADOR:
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserRequest request)
        {
            var result = _securityService.IniciarSesion(request);
            
            if (!result.IsSuccess)
            {
                return BadRequest(new { message = result.Message, errorCode = result.ErrorCode });
            }
            
            return Ok(result.Data);
        }
        
        
        EJEMPLO 2: Validación con múltiples errores
        ============================================
        
        public Result<UsuarioDTO> CrearUsuario(EdicionUsuarioRequest request)
        {
            var validationErrors = new List<string>();
            
            if (request.Usuario is null)
            {
                validationErrors.Add("El usuario es obligatorio");
            }
            
            if (string.IsNullOrEmpty(request.Usuario?.UsuarioId))
            {
                validationErrors.Add("El ID de usuario es obligatorio");
            }
            
            if (validationErrors.Any())
            {
                return Result<UsuarioDTO>.ValidationFailure(
                    "Validación fallida",
                    validationErrors,
                    "VALIDATION_ERROR"
                );
            }
            
            var usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.Usuario.UsuarioId);
            
            if (usuarioExiste.IsNotNull())
            {
                return Result<UsuarioDTO>.Failure("Usuario ya está registrado", "USER_ALREADY_EXISTS");
            }
            
            var usuario = new Usuario { ... };
            _genericRepository.Add(usuario);
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            
            return Result<UsuarioDTO>.Success(
                _mapper.Map<UsuarioDTO>(usuario),
                "Usuario creado exitosamente"
            );
        }
        
        // USO EN CONTROLADOR:
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] EdicionUsuarioRequest request)
        {
            var result = _securityService.CrearUsuario(request);
            
            if (!result.IsSuccess)
            {
                if (result.Errors.Any())
                {
                    return BadRequest(new 
                    { 
                        message = result.Message,
                        errors = result.Errors.ToList(),
                        errorCode = result.ErrorCode 
                    });
                }
                
                return BadRequest(new { message = result.Message, errorCode = result.ErrorCode });
            }
            
            return Created($"users/{result.Data.UsuarioId}", result.Data);
        }
        
        
        EJEMPLO 3: Encadenamiento con Bind
        ===================================
        
        public Result<PermisosDTO> AsignarPermisos(int usuarioId, List<PermisoRequest> permisos)
        {
            return ObtenerUsuarioVerificado(usuarioId)
                .Bind(usuario => ValidarPermisos(permisos))
                .Bind(permisosValidos => GuardarPermisos(usuarioId, permisosValidos))
                .Map(permisosGuardados => new PermisosDTO { ... });
        }
        
        
        EJEMPLO 4: Transformación con Map
        ==================================
        
        var resultado = _securityService.ObtenerUsuario(userId)
            .Map(usuario => new UsuarioResumenDTO 
            { 
                Id = usuario.UsuarioId,
                NombreCompleto = $"{usuario.Nombre} {usuario.Apellido}"
            });
        
        if (resultado.IsSuccess)
        {
            return Ok(resultado.Data);
        }
        
        return NotFound(new { message = resultado.Message });
        */

        /// <summary>
        /// Ventajas del Patrón Result:
        /// 
        /// 1. Type-safe: El compilador asegura que verificas IsSuccess antes de acceder a Data
        /// 2. Explícito: Los errores son parte del contrato del método
        /// 3. Sin excepciones: Evita el overhead de las excepciones para casos esperados
        /// 4. Composable: Puedes usar Map y Bind para encadenar operaciones
        /// 5. Testeable: Fácil de testear sin necesidad de mocking de excepciones
        /// 6. API consistente: Todos los métodos retornan Result<T>
        /// 
        /// Pasos para migrar el código actual:
        /// 
        /// 1. Cambiar tipos de retorno de métodos:
        ///    UsuarioDTO IniciarSesion(...) → Result<UsuarioDTO> IniciarSesion(...)
        ///
        /// 2. Reemplazar retornos con message por Result.Success() o Result.Failure():
        ///    return new UsuarioDTO { Message = "Error" } → Result<UsuarioDTO>.Failure("Error")
        ///
        /// 3. Actualizar controladores para revisar IsSuccess y acceder a Data:
        ///    var usuario = dto; → var result = service.Method(); if (result.IsSuccess) { var usuario = result.Data; }
        ///
        /// 4. Manejar errores de validación con ValidationFailure()
        ///
        /// 5. Usar Map para transformaciones simples
        /// 6. Usar Bind para operaciones que devuelven otro Result
        /// </summary>
        public class MigrationGuide { }
    }
}
