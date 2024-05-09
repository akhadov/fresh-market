using Domain.Categories;

namespace Infrastructure.Persistence.Repositories;

public class CategoryRepository : Repository<Category, CategoryId>, ICategoryRepository
{
    private readonly ApplicationDbContext context;

    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }

}