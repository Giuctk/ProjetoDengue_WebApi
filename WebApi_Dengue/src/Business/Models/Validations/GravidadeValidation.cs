using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.Validations
{
    public class GravidadeValidation : AbstractValidator<Gravidade>
    {
        public GravidadeValidation()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} presica ser fornecido")
                .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(x => x.Prioridade)
                .NotEmpty().WithMessage("O campo {PropertyName} presica ser fornecido")
                .NotNull().WithMessage("O campo {PropertyName} presica ser fornecido");
        }
    }
}
