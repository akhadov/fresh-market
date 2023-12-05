using System;
namespace Application.Common.Interfaces.Persistence;

public interface IRepository<TEntity>
{
    Task<TEntity> GetAllAsync();

    Task<TEntity?> GetByIdAsync(long id);

    IQueryable<TEntity> GetQueryable();

    void Insert(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task SaveChangesAsync();
}
