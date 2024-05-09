using Application.Abstractions.Messaging;
using Domain.Categories;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Categories.Queries.GetById;

internal sealed class GetCategoryByIdQueryHandler(
    ICategoryRepository categoryRepository) : IQueryHandler<GetCategoryByIdQuery, CategoryResponse>
{
    public async Task<Result<CategoryResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(request.CategoryId);

        if (category is null)
        {
            return Result.Failure<CategoryResponse>(CategoryErrors.NotFound(request.CategoryId));
        }

        var categoryResponse = new CategoryResponse
        {
            CategoryId = category.Id,
            Name = category.Name,
            ImagePath = category.ImagePath
        };

        return Result<CategoryResponse>.Success(categoryResponse);
    }
}
