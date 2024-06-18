using Microsoft.EntityFrameworkCore;
using SharedKernel.Base;
using SharedKernel.Interfaces;

namespace Infrastructure.Persistence.Repositories;

public class Repository<TEntity, TEntityId> : IRepository<TEntity, TEntityId>
    where TEntity : AggregateRoot<TEntityId>
    where TEntityId : class
{
    protected readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _context.Set<TEntity>().AddAsync(entity, cancellationToken);
        return entity;
    }

    public async Task RemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _context.Set<TEntity>().Remove(entity);
        await Task.CompletedTask;
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public async virtual Task<TEntity?> GetByIdAsync(TEntityId id, CancellationToken cancellationToken = default)
    {
        return await _context.Set<TEntity>()
            .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await Task.CompletedTask;
    }
}
