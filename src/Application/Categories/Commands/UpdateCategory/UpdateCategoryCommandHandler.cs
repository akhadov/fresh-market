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
        var category = await categoryRepository.GetByIdAsync(request.CategoryId);

        if (category is null)
        {
            return Result.Failure<Guid>(CategoryErrors.NotFound(request.CategoryId));
        }

        category.UpdateName(request.Name);

        category.UpdateImagePath(request.ImagePath);

        await categoryRepository.UpdateAsync(category);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return category.Id.Value;
    }
}
