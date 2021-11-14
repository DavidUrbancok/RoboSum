namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="Competitor"/> entity.
/// 
/// </summary>
public class CompetitorRepository : AbstractRepository<Competitor>, ICompetitorRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompetitorRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public CompetitorRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
