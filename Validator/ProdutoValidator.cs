using Ecommerce_Farmacia.Model;
using FluentValidation;

namespace Ecommerce_Farmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(100);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);

            RuleFor(p => p.Preco)
                .NotEmpty()
                .GreaterThan(0)
                .PrecisionScale(20, 2, false);

            RuleFor(p => p.Foto)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(2000);

        }
    }
}
