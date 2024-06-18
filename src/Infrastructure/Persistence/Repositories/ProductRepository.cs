using Domain.Products;

namespace Infrastructure.Persistence.Repositories;

public class ProductRepository : Repository<Product, ProductId>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }

    // Add any additional methods specific to ProductRepository if needed
}
