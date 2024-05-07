using Application.Abstractions.Data;
using Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Persistence.Interceptors;

namespace Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{
    private readonly EntitySaveChangesInterceptor _saveChangesInterceptor;
    private readonly DispatchDomainEventsInterceptor _dispatchDomainEventsInterceptor;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(
            _saveChangesInterceptor,
            _dispatchDomainEventsInterceptor);
    }
}
