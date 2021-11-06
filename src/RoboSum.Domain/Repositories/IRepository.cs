namespace RoboSum.Domain.Repositories
{
    using System.Linq.Expressions;

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
        Task<TEntity> GetAsync(int id);

        /// <summary>
        /// Asynchronously gets all entities of <typeparamref name="TEntity"/>.
        /// </summary>
        /// <returns>A <see cref="Task{TEntity}"/> containing all the found entities.</returns>
        Task<IQueryable<TEntity>> GetAllAsync();

        /// <summary>
        /// Asynchronously gets all entities of <typeparamref name="TEntity"/> satisfying the condition in <paramref name="condition"/>.
        /// </summary>
        /// <param name="condition">The condition to satisfy.</param>
        /// <returns>A <see cref="Task{TEntity}"/> containing all entities found by <paramref name="condition"/>.</returns>
        Task<IQueryable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> condition);

        /// <summary>
        /// Asynchronously adds the entity of <typeparamref name="TEntity"/> type to the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to persist.</param>
        /// <returns>A <see cref="Task{TEntity}"/> representing the current asynchronous operation.</returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Asynchronously updates the entity of <typeparamref name="TEntity"/> type in the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A <see cref="Task{TEntity}"/> representing the current asynchronous operation.</returns>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Asynchronously deletes the entity of <typeparamref name="TEntity"/> type from the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>A <see cref="Task{TEntity}"/> representing the current asynchronous operation.</returns>
        Task DeleteAsync(TEntity entity);
    }
}
