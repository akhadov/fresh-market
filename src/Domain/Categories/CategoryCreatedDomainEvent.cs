using SharedKernel.Base;

namespace Domain.Categories;

public record CategoryCreatedDomainEvent(CategoryId CategoryId, string Name, string ImagePath) : DomainEvent;
