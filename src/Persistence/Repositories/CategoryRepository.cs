using Application.Common.Interfaces.Persistence;
using Domain.Categories;

namespace Persistence.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {

    }
}