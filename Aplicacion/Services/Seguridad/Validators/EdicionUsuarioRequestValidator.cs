using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class EdicionUsuarioRequestValidator : AbstractValidator<EdicionUsuarioRequest>
    {
        public EdicionUsuarioRequestValidator()
        {
            RuleFor(x => x.Usuario).NotNull().WithMessage("Usuario es requerido").SetValidator(new UsuarioDTOValidator());
        }
    }
}
