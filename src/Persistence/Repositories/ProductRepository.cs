using Application.Common.Interfaces.Persistence;
using Domain.Entities.Catalog;

namespace Persistence.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
