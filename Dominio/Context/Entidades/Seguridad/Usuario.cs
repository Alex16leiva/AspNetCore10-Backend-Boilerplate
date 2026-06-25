using Dominio.Core;
using Dominio.Core.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Context.Entidades.Seguridad
{
    public class Usuario : Entity
    {
        [Key]
        public required string UsuarioId { get; set; }
        public required string Contrasena { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required bool Activo { get; set; }
        public string? RolId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        [NotMapped]
        public string? Token { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol? Rol { get; set; }

        public bool EstaDesactivado()
        {
            return !Activo;
        }

        public bool TienePermisoEditar(string pantalla)
        {
            // Si el Rol es nulo o la colección de permisos está vacía/nula, no tiene permisos
            if (Rol.IsNull() || Rol.Permisos.IsNull())
            {
                return false;
            }

            // Usamos Any para comprobar directamente la existencia del permiso con la condición requerida.
            // Esto es más limpio y directo que usar FirstOrDefault.
            return Rol.Permisos.Any(x => x.PantallaId == pantalla && x.Editar);
        }
    }
}
