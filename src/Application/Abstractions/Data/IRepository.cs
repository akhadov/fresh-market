namespace Application.Abstractions.Data;

public interface IRepository<TEntity> where TEntity : class
{
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(long id);
    Task<TEntity> CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}
