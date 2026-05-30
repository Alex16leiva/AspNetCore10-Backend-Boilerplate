using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class UsuarioDTOValidator : AbstractValidator<UsuarioDTO>
    {
        public UsuarioDTOValidator()
        {
            RuleFor(x => x.UsuarioId).NotEmpty().WithMessage("UsuarioId es requerido").MaximumLength(25);
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("Nombre es requerido");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("Apellido es requerido");
            RuleFor(x => x.RolId).NotEmpty().WithMessage("RolId es requerido");
            RuleFor(x => x.Contrasena)
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres")
                .When(x => x.EditarContrasena);
        }
    }
}
