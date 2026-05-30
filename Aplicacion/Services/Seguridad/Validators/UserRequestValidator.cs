using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class UserRequestValidator : AbstractValidator<UserRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(x => x.UsuarioId).NotEmpty().WithMessage("UsuarioId es requerido").MaximumLength(25);
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password es requerido").MinimumLength(8);
        }
    }
}
