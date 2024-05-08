using SharedKernel.Interfaces;

namespace Domain.Categories;

public interface ICategoryRepository : IRepository<Category, CategoryId>
{
}
