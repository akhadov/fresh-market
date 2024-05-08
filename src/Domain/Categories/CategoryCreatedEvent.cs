using SharedKernel.Base;

namespace Domain.Categories;

public record CategoryCreatedEvent(CategoryId CategoryId, string Name) : DomainEvent
{
    public static CategoryCreatedEvent Create(Category category) => new(category.Id, category.Name);
}
