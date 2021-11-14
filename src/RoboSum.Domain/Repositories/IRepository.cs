namespace RoboSum.Domain.Repositories;

/// <summary>
/// Represents a contract for all basic operations on model classes.
/// </summary>
/// <typeparam name="TEntity">The type of the entity class.</typeparam>
public interface IRepository<TEntity> : IUnitOfWork
    where TEntity : class
{
    /// <summary>
    /// Asynchronously gets the entity of <typeparamref name="TEntity"/> type by <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The ID of the entity.</param>
    /// <returns>A <see cref="Task{TEntity}"/> containing the entity found by <paramref name="id"/>.</returns>
    ValueTask<TEntity> GetByIdAsync(int id);

    /// <summary>
    /// Gets all entities of <typeparamref name="TEntity"/>.
    /// </summary>
    /// <returns>A <see cref="Task{TEntity}"/> containing all the found entities.</returns>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Asynchronously adds the entity of <typeparamref name="TEntity"/> type to the persistence layer.
    /// </summary>
    /// <param name="entity">The entity to persist.</param>
    /// <returns>
    /// A <see cref="Task"/> representing the current asynchronous operation.
    /// The task result contains the number of state entries written to the database.
    /// </returns>
    Task<int> AddAsync(TEntity entity);

    /// <summary>
    /// Asynchronously updates the entity of <typeparamref name="TEntity"/> type in the persistence layer.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <returns>
    /// A <see cref="Task"/> representing the current asynchronous operation.
    /// The task result contains the number of state entries written to the database.
    /// </returns>
    Task<int> UpdateAsync(TEntity entity);

    /// <summary>
    /// Asynchronously deletes the entity of <typeparamref name="TEntity"/> type from the persistence layer.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <returns>
    /// A <see cref="Task"/> representing the current asynchronous operation.
    /// The task result contains the number of state entries removed from the database.
    /// </returns>
    Task<int> DeleteAsync(TEntity entity);
}
