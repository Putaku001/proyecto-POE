using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class RequestClientValidation : AbstractValidator<RequestProjects>
    {
        public RequestClientValidation()
        {
            RuleLevelCascadeMode = CascadeMode.Stop; 

            RuleFor(project => project.nameProject)
                .NotEmpty().WithMessage("El nombre del proyecto no puede estar vacío.")
                .Length(5, 20).WithMessage("El nombre del proyecto debe tener entre 5 y 20 caracteres.");

            RuleFor(project => project.descriptionProject)
                .NotEmpty().WithMessage("La descripción del proyecto no puede estar vacía.")
                .MaximumLength(500).WithMessage("La descripción del proyecto no puede exceder los 500 caracteres.");
        }

    }
    
}
