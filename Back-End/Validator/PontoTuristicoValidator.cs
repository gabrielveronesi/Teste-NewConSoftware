using Back_End.Models;
using FluentValidation;

namespace Back_End.Validator
{
    public class PontoTuristicoValidator : AbstractValidator<PontoTuristico>
    {
        public PontoTuristicoValidator()
        {
            //Nome
            RuleFor(e => e.Nome).NotNull()
                                 .NotEmpty()
                                 .MaximumLength(80);


            //Descrição
            RuleFor(e => e.Descricao).NotNull()
                                 .NotEmpty()
                                 .MaximumLength(80)
                                 .WithMessage("Este campo deve conter menos que 100 catacteres");

            //Localização
            RuleFor(e => e.Nome).NotNull()
                                 .NotEmpty()
                                 .MaximumLength(80);

            //Cidade
            RuleFor(e => e.Nome).NotNull()
                                 .NotEmpty()
                                 .MaximumLength(80);

            //Estado
            RuleFor(e => e.Nome).NotNull()
                                 .NotEmpty()
                                 .MaximumLength(80);

        }
    }
}