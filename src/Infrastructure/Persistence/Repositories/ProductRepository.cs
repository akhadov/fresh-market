using Domain.Products;

namespace Infrastructure.Persistence.Repositories;

public class ProductRepository : Repository<Product, ProductId>, IProductRepository
{
    private readonly ApplicationDbContext context;

    public ProductRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}
