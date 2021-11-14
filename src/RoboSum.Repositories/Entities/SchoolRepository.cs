namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="School"/> entity.
/// </summary>
public class SchoolRepository : AbstractRepository<School>, ISchoolRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchoolRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public SchoolRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
