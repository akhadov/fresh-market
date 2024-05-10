using SharedKernel.Interfaces;

namespace Domain.Products;

public interface IProductRepository : IRepository<Product, ProductId>
{
}
