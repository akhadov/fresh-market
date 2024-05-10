using FluentValidation;

namespace Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty();

        RuleFor(p => p.Sku)
            .NotEmpty();

        RuleFor(p => p.Amount)
            .NotEmpty()
            .GreaterThan(0);

        RuleFor(p => p.Currency)
            .NotEmpty();
    }
}
