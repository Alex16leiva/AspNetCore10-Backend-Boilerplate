# Patrón Result - Guía de Implementación

## Descripción General

El **Patrón Result** encapsula el resultado de una operación (éxito o fallo) en un objeto type-safe. Reemplaza la necesidad de retornar DTOs con propiedades de mensaje o lanzar excepciones para casos de error esperados.

## Estructura

### 1. **IResult** (Interfaz Base)
```csharp
public interface IResult
{
    bool IsSuccess { get; }           // ¿Operación exitosa?
    string Message { get; }            // Mensaje de resultado
    string? ErrorCode { get; }         // Código de error (opcional)
    IReadOnlyCollection<string> Errors { get; } // Errores detallados
}
```

### 2. **Result** (Clase Base)
Resultados sin valor genérico, para operaciones que no retornan datos.

```csharp
// Crear resultado exitoso
var success = Result.Success("Operación completada");

// Crear resultado fallido
var failure = Result.Failure("Algo falló", errorCode: "ERR_001");

// Crear resultado con múltiples errores
var validation = Result.ValidationFailure(
    "Validación fallida",
    new[] { "Campo 1 requerido", "Campo 2 inválido" },
    errorCode: "VALIDATION_ERROR"
);
```

### 3. **Result<T>** (Clase Genérica)
Para operaciones que retornan un valor de tipo `T`.

```csharp
// Crear resultado exitoso con datos
var success = Result<Usuario>.Success(usuario, "Usuario creado");

// Crear resultado fallido (sin datos)
var failure = Result<Usuario>.Failure("Usuario no encontrado", "USER_NOT_FOUND");

// Crear resultado con errores de validación
var validation = Result<Usuario>.ValidationFailure(
    "Datos inválidos",
    new[] { "Email duplicado", "Contraseña muy corta" }
);
```

## Uso en Servicios

### Antes (Antipatrón)
```csharp
public UsuarioDTO CrearUsuario(EdicionUsuarioRequest request)
{
    if (usuarioExiste)
    {
        return new UsuarioDTO { Message = "Usuario ya existe", UsuarioId = "" };
    }
    
    return new UsuarioDTO { UsuarioId = nuevoUsuario.Id, Message = "Éxito" };
}
```

### Después (Patrón Result)
```csharp
public Result<UsuarioDTO> CrearUsuario(EdicionUsuarioRequest request)
{
    if (usuarioExiste)
    {
        return Result<UsuarioDTO>.Failure("Usuario ya existe", "USER_EXISTS");
    }
    
    var usuarioDto = _mapper.Map<UsuarioDTO>(nuevoUsuario);
    return Result<UsuarioDTO>.Success(usuarioDto, "Usuario creado exitosamente");
}
```

## Uso en Controladores

### Con Result<T>
```csharp
[HttpPost("create")]
public IActionResult Create([FromBody] EdicionUsuarioRequest request)
{
    var result = _securityService.CrearUsuario(request);
    
    // Verificación simplificada
    if (!result.IsSuccess)
    {
        if (result.Errors.Any())
        {
            return BadRequest(new { message = result.Message, errors = result.Errors });
        }
        return BadRequest(new { message = result.Message });
    }
    
    return Created($"/users/{result.Data.UsuarioId}", result.Data);
}
```

## Métodos Auxiliares

### **Map<TNew>** - Transformación de Datos
Transforma el valor exitoso sin afectar el estado de error.

```csharp
var usuarioResult = _service.ObtenerUsuario(id);

var dtoResult = usuarioResult.Map(usuario => new UsuarioResumenDTO
{
    Id = usuario.Id,
    NombreCompleto = $"{usuario.Nombre} {usuario.Apellido}"
});

if (dtoResult.IsSuccess)
{
    return Ok(dtoResult.Data); // UsuarioResumenDTO
}
```

### **Bind<TNew>** - Encadenamiento de Operaciones
Encadena operaciones que retornan otro `Result<T>`.

```csharp
public Result<PermisoDTO> ObtenerPermisosDeUsuario(int usuarioId)
{
    return ObtenerUsuario(usuarioId)           // Result<Usuario>
        .Bind(usuario => ObtenerRol(usuario.RolId))  // Result<Rol>
        .Bind(rol => ObtenerPermisos(rol.Id))        // Result<List<Permiso>>
        .Map(permisos => new PermisoDTO { ... });    // Result<PermisoDTO>
}
```

## Manejo de Errores de Validación

```csharp
public Result<UsuarioDTO> EditarUsuario(EdicionUsuarioRequest request)
{
    var erroresValidacion = new List<string>();
    
    if (request.Usuario is null)
        erroresValidacion.Add("El usuario es obligatorio");
    
    if (string.IsNullOrEmpty(request.Usuario?.UsuarioId))
        erroresValidacion.Add("ID de usuario es obligatorio");
    
    if (erroresValidacion.Any())
    {
        return Result<UsuarioDTO>.ValidationFailure(
            "Validación fallida",
            erroresValidacion,
            "VALIDATION_ERROR"
        );
    }
    
    // Resto de la lógica...
    return Result<UsuarioDTO>.Success(usuarioDto);
}
```

## Beneficios

| Aspecto | Benefit |
|--------|---------|
| **Type-Safe** | El compilador fuerza revisión de errores |
| **Explícito** | Los errores son parte del contrato del método |
| **Sin Excepciones** | Evita overhead para casos esperados |
| **Composable** | Map y Bind para composición funcional |
| **Testeable** | Fácil de testear sin mocking complejo |
| **Mantenible** | Código más limpio y predecible |

## Plan de Migración (Gradual)

1. ✅ **Implementar clases Result** (Done)
2. 🔄 **Refactorizar SecurityApplicationService** (Próximo)
   - CrearUsuario
   - EditarUsuario
   - IniciarSesion
   - RefreshToken
3. 🔄 **Actualizar Controladores** (Después)
4. 🔄 **Extender a otros servicios** (Opcional)

## Ejemplos de Códigos de Error

```
USER_NOT_FOUND       → Usuario no existe
INVALID_PASSWORD     → Contraseña incorrecta
USER_ALREADY_EXISTS  → Usuario duplicado
ROLE_NOT_FOUND       → Rol no existe
VALIDATION_ERROR     → Error de validación
UNAUTHORIZED         → No autorizado
FORBIDDEN            → Acceso denegado
INTERNAL_ERROR       → Error interno del servidor
```

## Referencias

- Patrón Result: https://github.com/nlkl/Optional
- Railway-Oriented Programming: https://fsharpforfunandprofit.com/posts/recipe-part2/
- C# Result Pattern: https://github.com/MbarkT3SL/SimpleResult
