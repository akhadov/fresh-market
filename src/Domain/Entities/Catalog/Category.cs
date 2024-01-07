using Domain.Common;

namespace Domain.Entities.Catalog;

public class Category : BaseEntity
{
    public string Name { get; set; }

    public string ImagePath { get; set; }
}
