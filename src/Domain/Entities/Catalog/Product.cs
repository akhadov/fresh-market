using Domain.Common;
using System;
namespace Domain.Entities.Catalog;

public class Product : BaseEntity
{
    public string Name { get; set; }

    public string ImagePath { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public long CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
