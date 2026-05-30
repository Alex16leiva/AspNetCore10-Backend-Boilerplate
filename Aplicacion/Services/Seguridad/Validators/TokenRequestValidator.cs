using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty().WithMessage("AccessToken es requerido");
            RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("RefreshToken es requerido");
        }
    }
}
