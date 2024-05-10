using Domain.Categories;
using Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;

public interface IApplicationDbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }
}
