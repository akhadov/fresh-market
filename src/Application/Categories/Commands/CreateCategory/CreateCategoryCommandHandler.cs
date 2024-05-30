using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Application.Abstractions.Storage;
using Domain.Categories;
using SharedKernel;

namespace Application.Categories.Commands.CreateCategory;

internal sealed class CreateCategoryCommandHandler(
ICategoryRepository categoryRepository,
IStorageService file,
IUnitOfWork unitOfWork) : ICommandHandler<CreateCategoryCommand, Guid>
{
    public async Task<Result<Guid>> Handle(
        CreateCategoryCommand request,
        CancellationToken cancellationToken)
    {
        var imagePath = await file.UploadAsync(request.Image);

        var category = Category.Create(request.Name, imagePath);

        await categoryRepository.AddAsync(category);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return category.Id.Value;

    }
}
