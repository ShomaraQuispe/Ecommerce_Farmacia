using Ecommerce_Farmacia.Model;
using FluentValidation;

namespace Ecommerce_Farmacia.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(p => p.Tipo)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
        }
    }
}
