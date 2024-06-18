using SharedKernel.Base;

namespace Domain.Categories;

public record CategoryId(Guid Value);

public class Category : AggregateRoot<CategoryId>
{
    public string Name { get; private set; } = default!;

    public string ImagePath { get; set; }

    private Category() { }

    public static Category Create(string name, string imagePath)
    {
        var category = new Category
        {
            Id = new CategoryId(Guid.NewGuid()),
            Name = name,
            ImagePath = imagePath
        };

        category.AddDomainEvent(new CategoryCreatedEvent(category));

        return category;
    }

    public void Update(string name, string imagePath)
    {
        Name = name;
        ImagePath = imagePath;
    }
}