using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class NewAccountValidation : AbstractValidator<User>
    {
        public NewAccountValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(user => user.UserAccount)
                .NotEmpty().WithMessage("El nombre de usuario es obligatorio.")
                .Length(3, 20).WithMessage("El nombre de usuario debe tener entre 3 y 20 caracteres.");

            RuleFor(user => user.NameUser)
                .NotEmpty().WithMessage("El nombre es obligatorio.");

            RuleFor(user => user.LastName)
                .NotEmpty().WithMessage("El apellido es obligatorio.");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
                .EmailAddress().WithMessage("El formato del correo electrónico es inválido.");

            RuleFor(user => user.NumberPhone)
                .NotEmpty().WithMessage("El número de teléfono es obligatorio.")
                .Matches(@"^\d{8}$").WithMessage("El número de teléfono debe tener 8 dígitos.");

            RuleFor(user => user.passworduser)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.");

            RuleFor(user => user.Country)
                .NotEmpty().WithMessage("El país es obligatorio.");

            RuleFor(user => user.City)
                .NotEmpty().WithMessage("La ciudad es obligatoria.");
        }

    }
}
