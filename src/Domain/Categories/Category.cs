using SharedKernel.Base;

namespace Domain.Categories;

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

        category.UpdateName(name);

        category.UpdateImagePath(imagePath);

        category.AddDomainEvent(CategoryCreatedDomainEvent.Create(category));

        return category;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateImagePath(string imagePath)
    {
        ImagePath = imagePath;
    }
}
