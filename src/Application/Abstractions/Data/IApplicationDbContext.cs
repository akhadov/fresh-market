using Domain.Blogs;
using Domain.Categories;
using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;

public interface IApplicationDbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<LineItem> LineItems { get; set; }

    public DbSet<BlogPost> BlogPosts { get; set; }

    public DbSet<BlogPostComment> BlogPostComments { get; set; }

    public DbSet<BlogPostTag> BlogPostTags { get; set; }


}
