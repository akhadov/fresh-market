using SharedKernel.Base;

namespace Domain.Products;

public record ProductCreatedEvent(Product Product) : DomainEvent;