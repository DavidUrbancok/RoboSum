namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="Referee"/> entity.
/// </summary>
public class RefereeRepository : AbstractRepository<Referee>, IRefereeRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefereeRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public RefereeRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
