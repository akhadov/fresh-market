using Application.Abstractions.Data;
using Domain.Blogs;
using Domain.Categories;
using Domain.Orders;
using Domain.Products;
using Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{
    private readonly EntitySaveChangesInterceptor saveChangesInterceptor;
    private readonly DispatchDomainEventsInterceptor dispatchDomainEventsInterceptor;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        EntitySaveChangesInterceptor saveChangesInterceptor,
        DispatchDomainEventsInterceptor dispatchDomainEventsInterceptor) : base(options)
    {
        this.saveChangesInterceptor = saveChangesInterceptor;
        this.dispatchDomainEventsInterceptor = dispatchDomainEventsInterceptor;
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<LineItem> LineItems { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<BlogPostComment> BlogPostComments { get; set; }
    public DbSet<BlogPostTag> BlogPostTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Order of the interceptors is important
        optionsBuilder.AddInterceptors(saveChangesInterceptor, dispatchDomainEventsInterceptor);
    }
}
