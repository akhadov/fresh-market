using SharedKernel.Base;

namespace SharedKernel;

public interface IRepository<TEntity, TEntityId> where TEntity : AggregateRoot<TEntityId>
{
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(TEntityId id);
    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task RemoveAsync(TEntity entity);
}
