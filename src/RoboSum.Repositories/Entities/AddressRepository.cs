namespace RoboSum.Repositories.Entities;

using Persistence.SQL;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.Persistence;

/// <summary>
/// Represents a repository for <see cref="Address"/> entity.
/// </summary>
public class AddressRepository : AbstractRepository<Address>, IAddressRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public AddressRepository(AbstractDbContext dbContext)
        : base(dbContext)
    {
    }
}
