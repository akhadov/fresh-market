using Domain.Entities.Catalog;

namespace Contracts.Catalogs;

public class ProductResponse
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string ImagePath { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public long CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}