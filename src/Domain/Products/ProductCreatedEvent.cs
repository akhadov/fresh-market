using SharedKernel.Base;

namespace Domain.Products;

public record ProductCreatedEvent(ProductId ProductId, string ProductName) : DomainEvent
{
    public static ProductCreatedEvent Create(Product product) => new(product.Id, product.Name);
}

