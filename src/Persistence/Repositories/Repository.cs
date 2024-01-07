using Application.Common.Interfaces.Persistence;

namespace Persistence.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    private readonly ApplicationDbContext _context;

    public Repository()
    {

    }

    public Task CreateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TEntity>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
