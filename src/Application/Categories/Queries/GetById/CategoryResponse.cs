using Domain.Categories;

namespace Application.Categories.Queries.GetById;

public record CategoryResponse
{
    public CategoryId CategoryId { get; init; }
    public string Name { get; init; }
    public string ImagePath { get; init; }

}
