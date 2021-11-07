namespace RoboSum.Repositories
{
    using RoboSum.Domain.Entities;
    using RoboSum.Domain.Repositories;
    using RoboSum.Domain.Repositories.Entities;
    using RoboSum.Persistence;
    using System.Linq;

    /// <summary>
    /// Represents a repository for <see cref="Address"/> entity.
    /// </summary>
    public class AddressRepository : IAddressRepository
    {
        private readonly AbstractDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown, when <paramref name="dbContext"/> is <see langword="null"/>.
        /// </exception>
        public AddressRepository(AbstractDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        /// <inheritdoc cref="IRepository{TEntity}.GetAsync(int)"/>
        public async Task<Address> GetAsync(int id)
        {
            return await _dbContext.Addresses.FindAsync(id);
        }

        /// <inheritdoc cref="IRepository{TEntity}.GetAll()"/>
        public IQueryable<Address> GetAll()
        {
            return _dbContext.Addresses.AsQueryable();
        }

        /// <inheritdoc cref="IRepository{TEntity}.AddAsync(TEntity)"/>
        public async Task AddAsync(Address entity)
        {
            await _dbContext.Addresses.AddAsync(entity);

            await SaveChangesAsync();
        }

        /// <inheritdoc cref="IRepository{TEntity}.UpdateAsync(TEntity)"/>
        public async Task UpdateAsync(Address entity)
        {
            _dbContext.Addresses.Update(entity);

            await SaveChangesAsync();
        }

        /// <inheritdoc cref="IRepository{TEntity}.DeleteAsync(TEntity)"/>
        public async Task DeleteAsync(Address entity)
        {
            _dbContext.Addresses.Remove(entity);

            await SaveChangesAsync();
        }

        /// <inheritdoc cref="IUnitOfWork.SaveChangesAsync(CancellationToken)"/>
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
