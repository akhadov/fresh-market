using Domain.Categories;

namespace Infrastructure.Persistence.Repositories;

public class CategoryRepository : Repository<Category, CategoryId>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

}