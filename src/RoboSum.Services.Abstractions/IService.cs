﻿namespace RoboSum.Services.Abstractions
{
    /// <summary>
    /// Represents a contract for a generic service for <typeparamref name="TDto"/> type.
    /// </summary>
    /// <typeparam name="TDto">The type of the DTO.</typeparam>
    public interface IService<TDto>
        where TDto : class
    {
        /// <summary>
        /// Asynchronously gets the entity of <typeparamref name="TDto"/> type by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the entity.</param>
        /// <returns>A <see cref="Task{TDto}"/> containing the entity found by <paramref name="id"/>.</returns>
        Task<TDto> GetAsync(int id);

        /// <summary>
        /// Gets all entities of <typeparamref name="TDto"/> type.
        /// </summary>
        /// <returns>A <see cref="Task{TDto}"/> containing all the found entities.</returns>
        IQueryable<TDto> GetAll();

        /// <summary>
        /// Asynchronously adds the entity of <typeparamref name="TDto"/> type to the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to persist.</param>
        /// <returns>A <see cref="Task{TDto}"/> representing the current asynchronous operation.</returns>
        Task AddAsync(TDto entity);

        /// <summary>
        /// Asynchronously updates the entity of <typeparamref name="TDto"/> type in the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A <see cref="Task{TDto}"/> representing the current asynchronous operation.</returns>
        Task UpdateAsync(TDto entity);

        /// <summary>
        /// Asynchronously deletes the entity of <typeparamref name="TDto"/> type from the persistence layer.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>A <see cref="Task{TDto}"/> representing the current asynchronous operation.</returns>
        Task DeleteAsync(TDto entity);
    }
}