using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Categories;
using MediatR;
using SharedKernel;

namespace Application.Categories.Commands.UpdateCategory;

internal sealed class UpdateCategoryCommandHandler(
    ICategoryRepository categoryRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<UpdateCategoryCommand, Guid>
{

    async Task<Result<Guid>> IRequestHandler<UpdateCategoryCommand, Result<Guid>>.Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(new CategoryId(request.CategoryId), cancellationToken);

        if (category is null)
        {
            return Result.Failure<Guid>(CategoryErrors.NotFound(request.CategoryId));
        }

        category.Update(request.Name, request.ImagePath);

        await categoryRepository.UpdateAsync(category, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return category.Id.Value;
    }
}
