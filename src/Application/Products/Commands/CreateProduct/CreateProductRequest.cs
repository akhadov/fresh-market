namespace Application.Products.Commands.CreateProduct;

public sealed record CreateProductRequest(
    string Name, string Sku, decimal Amount, string Currency, Guid CategoryId);
