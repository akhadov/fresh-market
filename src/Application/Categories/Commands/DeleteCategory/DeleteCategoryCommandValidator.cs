using FluentValidation;

namespace Application.Categories.Commands.DeleteCategory;

internal sealed class DeleteCategoryCommandValidator : AbstractValidator<DeleteCategoryCommand>
{
    public DeleteCategoryCommandValidator()
    {
        RuleFor(x => x.CategoryId).NotEmpty().WithErrorCode(CategoryErrorCodes.DeleteCategory.MissingCategoryId);
    }
}
