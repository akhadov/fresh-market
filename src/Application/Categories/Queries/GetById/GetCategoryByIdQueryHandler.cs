using Application.Abstractions.Messaging;
using Domain.Categories;
using SharedKernel;

namespace Application.Categories.Queries.GetById;

internal sealed class GetCategoryByIdQueryHandler(
    ICategoryRepository categoryRepository) : IQueryHandler<GetCategoryByIdQuery, CategoryResponse>
{
    public async Task<Result<CategoryResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(new CategoryId(request.CategoryId), cancellationToken);

        if (category is null)
        {
            return Result.Failure<CategoryResponse>(CategoryErrors.NotFound(request.CategoryId));
        }

        var categoryResponse = new CategoryResponse
        {
            Id = category.Id.Value,
            Name = category.Name,
            ImagePath = category.ImagePath
        };

        return Result<CategoryResponse>.Success(categoryResponse);
    }
}
