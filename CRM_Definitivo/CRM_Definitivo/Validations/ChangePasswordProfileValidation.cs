using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class ChangePasswordProfileValidation : AbstractValidator<User>
    {
        public ChangePasswordProfileValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(user => user.passworduser)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches(@"[A-Z]").WithMessage("La contraseña debe incluir al menos una letra mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe incluir al menos una letra minúscula.")
                .Matches(@"\d").WithMessage("La contraseña debe incluir al menos un número.")
                .Matches(@"[\W_]").WithMessage("La contraseña debe incluir al menos un carácter especial.");
        }
    }
}
