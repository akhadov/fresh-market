using FluentValidation;

namespace Application.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
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

