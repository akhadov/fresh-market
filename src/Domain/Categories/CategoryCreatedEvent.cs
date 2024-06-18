using SharedKernel.Base;

namespace Domain.Categories;

public record CategoryCreatedEvent(Category Category) : DomainEvent;