using SharedKernel.Base;

namespace Domain.Products;

public record ProductCreatedDomainEvent(ProductId ProductId, string ProductName) : DomainEvent
{
    public static ProductCreatedDomainEvent Create(Product product) => new(product.Id, product.Name);
}
