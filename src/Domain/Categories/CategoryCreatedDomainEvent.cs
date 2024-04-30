using SharedKernel.Base;

namespace Domain.Categories;

public record CategoryCreatedDomainEvent(CategoryId CategoryId, string Name) : DomainEvent
{
    public static CategoryCreatedDomainEvent Create(Category category) => new(category.Id, category.Name);
}