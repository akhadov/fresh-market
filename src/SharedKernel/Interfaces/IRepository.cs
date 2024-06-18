using SharedKernel.Base;

namespace SharedKernel.Interfaces;

public interface IRepository<TEntity, TEntityId> where TEntity : AggregateRoot<TEntityId>
{
    Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(TEntityId id, CancellationToken cancellationToken = default);
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);
}