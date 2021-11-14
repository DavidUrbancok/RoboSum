namespace RoboSum.Repositories.Entities;

using Microsoft.EntityFrameworkCore;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents a repository for <see cref="Person"/> entity.
/// </summary>
public class PersonRepository : AbstractRepository<Person>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public PersonRepository(DbContext dbContext)
        : base(dbContext)
    {
    }
}
