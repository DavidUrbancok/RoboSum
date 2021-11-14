namespace RoboSum.Repositories.Entities;

using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.Persistence;

/// <summary>
/// Represents a repository for <see cref="Competition"/> entity.
/// </summary>
public class CompetitionRepository : AbstractRepository<Competition>, ICompetitionRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompetitionRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public CompetitionRepository(AbstractDbContext dbContext)
        : base(dbContext)
    {
    }
}
