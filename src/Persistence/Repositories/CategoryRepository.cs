using Domain.Categories;

namespace Persistence.Repositories;

public class CategoryRepository : Repository<Category, CategoryId>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

}
