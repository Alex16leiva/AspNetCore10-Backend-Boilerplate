# AGENTS.md

## Reglas del proyecto

- Usar siempre las extensiones de `Dominio.Core.Extensions` para validar nulos, cadenas vacías y valores faltantes antes de acceder a propiedades o invocar métodos.
- Preferir `IsNull()`, `IsNotNull()`, `IsMissingValue()`, `ValueOrEmpty()`, `ToStringValue()`, `HasItems()`, etc., sobre comparaciones manuales con `== null`, `string.IsNullOrEmpty`, `string.IsNullOrWhiteSpace` y `string.Empty` cuando exista una extensión equivalente.
- Tratar `string?` como opcional y convertirlo con `ValueOrEmpty()` cuando se necesite un valor seguro para persistencia o logs.
- Evitar asignaciones con `null` a propiedades no anulables; validar primero y usar `!` solo cuando ya se haya comprobado la disponibilidad del valor.
- Para colecciones, usar `IsNull()` / `IsNotNull()` y `HasItems()` antes de iterar.

## Extensiones recomendadas

- `obj.IsNull()` / `obj.IsNotNull()`
- `str.IsMissingValue()`
- `str.ValueOrEmpty()`
- `obj.ToStringValue()`
- `collection.HasItems()`

## Ejemplos

```csharp
if (request.IsNull())
    return resultado;

if (usuarioId.IsMissingValue())
    return false;

var nombre = request.Nombre.ValueOrEmpty();

foreach (var item in permisos.Where(x => x.IsNotNull()))
{
    // lógica
}
```

## Objetivo

Estas reglas evitan errores de nulabilidad, reducen código repetitivo y mantienen una convención uniforme en toda la solución.
