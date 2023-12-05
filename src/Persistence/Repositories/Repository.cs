using Application.Common.Interfaces.Persistence;

namespace Persistence.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
{

    public Task<TEntity> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetQueryable()
    {
        throw new NotImplementedException();
    }

    public void Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
    
}
