namespace RoboSum.Domain.Repositories;

/// <summary>
/// Represents a contract for all methods for one unit of work (add, update, delete) in the persistence layer.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Asynchronously saves the changes to the persistence layer.
    /// </summary>
    /// <param name="cancellationToken">The token representing the cancellation of the current operation.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
