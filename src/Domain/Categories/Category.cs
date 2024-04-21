using SharedKernel.Base;

namespace Domain.Categories;

public class Category : AggregateRoot<CategoryId>
{
    public string Name { get; private set; } = default!;

    public string ImagePath { get; set; }

    private Category() { }


}
