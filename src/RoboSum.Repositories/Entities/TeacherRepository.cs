namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;

/// <summary>
/// Represents a repository for <see cref="Teacher"/> entity.
/// </summary>
public class TeacherRepository : AbstractRepository<Teacher>, ITeacherRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public TeacherRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
