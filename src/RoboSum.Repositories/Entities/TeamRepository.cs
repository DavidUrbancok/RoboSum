namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="Team"/> entity.
/// </summary>
public class TeamRepository : AbstractRepository<Team>, ITeamRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public TeamRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
