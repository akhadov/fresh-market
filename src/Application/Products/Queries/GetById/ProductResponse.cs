namespace Application.Products.Queries.GetById;

public record ProductResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Sku { get; init; }
    public string Currency { get; init; }
    public decimal Amount { get; init; }
}
