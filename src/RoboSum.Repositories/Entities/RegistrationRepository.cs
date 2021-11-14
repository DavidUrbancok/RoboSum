namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="Registration"/> entity.
/// </summary>
public class RegistrationRepository : AbstractRepository<Registration>, IRegistrationRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegistrationRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public RegistrationRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
