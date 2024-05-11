using Domain.Categories;
using SharedKernel.Base;

namespace Domain.Products;

public class Product : AggregateRoot<ProductId>
{
    public CategoryId CategoryId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Money Price { get; private set; }

    public Sku Sku { get; private set; }

    private Product() { }

    public static Product Create(string name, Money price, Sku sku, CategoryId categoryId)
    {

        var product = new Product
        {
            Id = new ProductId(Guid.NewGuid()),
            CategoryId = categoryId,
            Name = name,
            Price = price,
            Sku = sku
        };

        product.AddDomainEvent(ProductCreatedEvent.Create(product));

        return product;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdatePrice(Money price)
    {

        Price = price;
    }

    public void UpdateSku(Sku sku)
    {
        Sku = sku;
    }
}