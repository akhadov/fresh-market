using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //{
    //    foreach (var entry in ChangeTracker.Entries<BaseAuditableEntity>())
    //    {
    //        entry.Entity.LastModified = DateTime.Now;

    //        if (entry.State == EntityState.Added)
    //        {
    //            entry.Entity.Created = DateTime.Now;
    //        }
    //    }

    //    return base.SaveChangesAsync(cancellationToken);
    //}
}
