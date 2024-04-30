using Domain.Categories;
using SharedKernel.Base;
using SharedKernel.Entities;
using SharedKernel.Exceptions;

namespace Domain.Products;

public class Product : AggregateRoot<ProductId>
{
    public CategoryId CategoryId { get; private set; }

    public Category Category { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Money Price { get; private set; }

    public Sku Sku { get; private set; }

    private Product() { }

    public static Product Create(string name, Money price, Sku sku, CategoryId categoryId)
    {
        Guard.Against.Null(name);
        Guard.Against.Null(price);
        Guard.Against.Null(sku);
        Guard.Against.ZeroOrNegative(price.Amount);
        Guard.Against.Null(categoryId);

        var product = new Product
        {
            Id = new ProductId(Guid.NewGuid()),
            CategoryId = categoryId,
            Name = name,
            Price = price,
            Sku = sku
        };

        product.AddDomainEvent(ProductCreatedDomainEvent.Create(product));

        return product;
    }

    public void UpdateName(string name)
    {
        Guard.Against.Empty(name);
        Name = name;
    }

    public void UpdatePrice(Money price)
    {
        Guard.Against.Null(price);
        Guard.Against.ZeroOrNegative(price.Amount);
        Price = price;
    }

    public void UpdateSku(Sku sku)
    {
        Guard.Against.Null(sku);
        Sku = sku;
    }
}
