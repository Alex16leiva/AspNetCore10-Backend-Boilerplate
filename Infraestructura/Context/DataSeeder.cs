using Dominio.Context.Entidades;
using Dominio.Context.Entidades.Seguridad;

namespace Infraestructura.Context
{
    public static class DataSeeder
    {
        public static void Seed(MyContext context, string? adminPassword = null)
        {
            var ahora = DateTime.Now;
            var modificadoPor = "System";
            var transaccionUId = Guid.NewGuid();
            var tipoTransaccion = "cargaInicial";
            var descripcionTransaccion = "Added";
            // Verifica si ya existen registros
            if (!context.Rol.Any())
            {
                context.Rol.AddRange(
                    new Rol 
                    { 
                        RolId = "Admin", 
                        Descripcion = "Administrador del sistema", 
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora, 
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion
                    },
                    new Rol 
                    { 
                        RolId = "User", 
                        Descripcion = "Usuario estándar", 
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        TipoTransaccion = tipoTransaccion,
                        TransaccionUId = transaccionUId
                    }
                );
            }

            if (!context.Usuarios.Any() && !string.IsNullOrWhiteSpace(adminPassword))
            {
                context.Usuarios.Add(
                    new Usuario 
                    {
                        UsuarioId = "admin", 
                        Nombre = "Administrador", 
                        Apellido = "Sistema",
                        Contrasena = PasswordEncryptor.HashPassword(adminPassword), 
                        RolId = "Admin",
                        Activo = true,
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora, 
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                    });
            }

            if (!context.Pantalla.Any())
            {   
                context.Pantalla.AddRange(
                    new Pantalla
                    {
                        PantallaId = "Seguridad",
                        Descripcion = "Administracion de la seguridad",
                        DescripcionTransaccion = descripcionTransaccion,
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                        
                    });
            }

            if (!context.Permisos.Any())
            {
                context.Permisos.AddRange(
                    new Permisos
                    {
                        RolId = "Admin",
                        PantallaId = "Seguridad",
                        DescripcionTransaccion = descripcionTransaccion,
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        Editar = true,
                        Eliminar = true,
                        Ver = true,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                    }
                );
            }
            // Guarda los cambios
            context.SaveChanges();
        }
    }
}
