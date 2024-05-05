using Domain.Categories;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;

public interface IApplicationDbContext
{
    public DbSet<Category> Categories { get; set; }
}
