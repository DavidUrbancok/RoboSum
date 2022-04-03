namespace RoboSum.Persistence.SQL;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Represents the application's database context. This is an abstract class.
/// </summary>
public class AbstractDbContext : DbContext
{
    /// <summary>
    /// Gets or sets the database set of addresses.
    /// </summary>
    /// <value>
    /// The database set of addresses.
    /// </value>
    public DbSet<Address> Addresses { get; set; }

    /// <summary>
    /// Gets or sets the database set of competitions.
    /// </summary>
    /// <value>
    /// The database set of competitions.
    /// </value>
    public DbSet<Competition> Competitions { get; set; }

    /// <summary>
    /// Gets or sets the database set of competitors.
    /// </summary>
    /// <value>
    /// The database set of competitors.
    /// </value>
    public DbSet<Competitor> Competitors { get; set; }

    /// <summary>
    /// Gets or sets the database set of referees.
    /// </summary>
    /// <value>
    /// The database set of referees.
    /// </value>
    public DbSet<Referee> Referees { get; set; }

    /// <summary>
    /// Gets or sets the database set of registrations.
    /// </summary>
    /// <value>
    /// The database set of registrations.
    /// </value>
    public DbSet<Registration> Registrations { get; set; }

    /// <summary>
    /// Gets or sets the database set of schools.
    /// </summary>
    /// <value>
    /// The database set of schools.
    /// </value>
    public DbSet<School> Schools { get; set; }

    /// <summary>
    /// Gets or sets the database set of teachers.
    /// </summary>
    /// <value>
    /// The database set of teachers.
    /// </value>
    public DbSet<Teacher> Teachers { get; set; }

    /// <summary>
    /// Gets or sets the database set of teams.
    /// </summary>
    /// <value>
    /// The database set of teams.
    /// </value>
    public DbSet<Team> Teams { get; set; }

    /// <inheritdoc cref="DbContext.OnModelCreating(ModelBuilder)"/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.ApplyConfigurationsFromAssembly(typeof(AbstractDbContext).Assembly);
    }
}
