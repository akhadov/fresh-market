using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Categories;
using SharedKernel.Results;

namespace Application.Categories.Commands.CreateCategory;

internal sealed class CreateCategoryCommandHandler(
    ICategoryRepository categoryRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateCategoryCommand, Guid>
{
    public async Task<Result<Guid>> Handle(
        CreateCategoryCommand request,
        CancellationToken cancellationToken)
    {
        var category = Category.Create(request.Name, request.ImagePath);

        await categoryRepository.AddAsync(category);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return category.Id.Value;

    }
}
