namespace RoboSum.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using RoboSum.Domain.Entities;

    /// <summary>
    /// Represents the application's database context. This is an abstract class.
    /// </summary>
    public class AbstractDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the database set of addresses.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the database set of competitions.
        /// </summary>
        public DbSet<Competition> Competitions { get; set; }

        /// <summary>
        /// Gets or sets the database set of competitors.
        /// </summary>
        public DbSet<Competitor> Competitors { get; set; }

        /// <summary>
        /// Gets or sets the database set of referees.
        /// </summary>
        public DbSet<Referee> Referees { get; set; }

        /// <summary>
        /// Gets or sets the database set of registrations.
        /// </summary>
        public DbSet<Registration> Registrations { get; set; }

        /// <summary>
        /// Gets or sets the database set of schools.
        /// </summary>
        public DbSet<School> Schools { get; set; }

        /// <summary>
        /// Gets or sets the database set of teachers.
        /// </summary>
        public DbSet<Teacher> Teachers { get; set; }

        /// <summary>
        /// Gets or sets the database set of teams.
        /// </summary>
        public DbSet<Team> Teams { get; set; }

        /// <inheritdoc cref="DbContext.OnModelCreating(ModelBuilder)"/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AbstractDbContext).Assembly);
        }
    }
}
