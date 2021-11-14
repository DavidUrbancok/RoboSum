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

    /// <inheritdoc cref="IRepository{TEntity}.GetByIdAsync(int)"/>
    public virtual ValueTask<TEntity> GetByIdAsync(int id)
    {
        return _entities.FindAsync(id);
    }

    /// <inheritdoc cref="IRepository{TEntity}.GetAll()"/>
    public virtual IQueryable<TEntity> GetAll()
    {
        return _entities.AsQueryable();
    }

    /// <inheritdoc cref="IRepository{TEntity}.AddAsync(TEntity)"/>
    public virtual async Task<int> AddAsync(TEntity entity)
    {
        await _entities.AddAsync(entity);

        return await SaveChangesAsync();
    }

    /// <inheritdoc cref="IRepository{TEntity}.UpdateAsync(TEntity)"/>
    public virtual Task<int> UpdateAsync(TEntity entity)
    {
        _entities.Update(entity);

        return SaveChangesAsync();
    }

    /// <inheritdoc cref="IRepository{TEntity}.DeleteAsync(TEntity)"/>
    public virtual Task<int> DeleteAsync(TEntity entity)
    {
        _entities.Remove(entity);

        return SaveChangesAsync();
    }

    /// <inheritdoc cref="IUnitOfWork.SaveChangesAsync(CancellationToken)"/>
    public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return DbContext.SaveChangesAsync(cancellationToken);
    }
}
