namespace RoboSum.Repositories;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Repositories;

/// <summary>
/// Represents basic CRUD operations to the persistance layer. This is an <see langword="abstract"/> class.
/// </summary>
/// <typeparam name="TEntity">The type of the entity in the DB set.</typeparam>
public abstract class AbstractRepository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    private readonly DbSet<TEntity> _entities;

    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractRepository{TEntity}"/> class.
    /// </summary>
    /// <param name="dbContext">The DB context.</param>
    protected AbstractRepository(DbContext dbContext)
    {
        DbContext = dbContext;
        _entities = dbContext.Set<TEntity>();
    }

    /// <summary>
    /// Gets the DB context.
    /// </summary>
    protected DbContext DbContext { get; }

    /// <inheritdoc cref="IRepository{TEntity}.GetByIdAsync(int, CancellationToken)"/>
    public virtual ValueTask<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return _entities.FindAsync(new object[] { id, cancellationToken }, cancellationToken);
    }

    /// <inheritdoc cref="IRepository{TEntity}.GetAll()"/>
    public virtual IQueryable<TEntity> GetAll()
    {
        return _entities.AsQueryable();
    }

    /// <inheritdoc cref="IRepository{TEntity}.AddAsync(TEntity, CancellationToken)"/>
    public virtual async Task<int> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _entities.AddAsync(entity, cancellationToken);

        return await SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc cref="IRepository{TEntity}.UpdateAsync(TEntity, CancellationToken)"/>
    public virtual Task<int> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _entities.Update(entity);

        return SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc cref="IRepository{TEntity}.RemoveAsync(TEntity, CancellationToken)"/>
    public virtual Task<int> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _entities.Remove(entity);

        return SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc cref="IUnitOfWork.SaveChangesAsync(CancellationToken)"/>
    public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return DbContext.SaveChangesAsync(cancellationToken);
    }
}
