namespace Application.Products.Commands.UpdateProduct;

public record UpdateProductRequest(
    string Name, string Sku, decimal Amount, string Currency, Guid CategoryId);
