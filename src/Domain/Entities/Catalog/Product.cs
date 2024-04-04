namespace Domain.Entities.Catalog;

public class Product
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string ImagePath { get; set; }

    public int StockQuantity { get; set; }

    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
