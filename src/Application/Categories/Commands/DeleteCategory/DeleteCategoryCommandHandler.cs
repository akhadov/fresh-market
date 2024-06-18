using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Categories;
using SharedKernel;

namespace Application.Categories.Commands.DeleteCategory;

internal sealed class DeleteCategoryCommandHandler(
    ICategoryRepository categoryRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<DeleteCategoryCommand>
{
    public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(new CategoryId(request.CategoryId), cancellationToken);

        if (category is null)
        {
            return Result.Failure(CategoryErrors.NotFound(request.CategoryId));
        }

        await categoryRepository.RemoveAsync(category, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
