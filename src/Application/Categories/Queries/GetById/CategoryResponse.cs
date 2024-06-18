namespace Application.Categories.Queries.GetById;

public record CategoryResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string ImagePath { get; init; }

}
