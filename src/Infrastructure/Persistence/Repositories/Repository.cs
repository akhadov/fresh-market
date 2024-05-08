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

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task RemoveAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await Task.CompletedTask;
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public virtual async Task<TEntity?> GetByIdAsync(TEntityId id)
    {
        return await _context.Set<TEntity>()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await Task.CompletedTask;
    }
}
