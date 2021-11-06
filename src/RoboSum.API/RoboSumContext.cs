namespace RoboSum.API
{
    using Microsoft.EntityFrameworkCore;
    using RoboSum.Models;

    /// <summary>
    /// Represents the database context class.
    /// </summary>
    public class RoboSumContext : DbContext
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoboSumContext"/> class.
        /// </summary>
        /// <param name="configuration">The web host builder configuration.</param>
        public RoboSumContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gets or sets the database set of addresses.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the database set of competitions.
        /// </summary>
        public DbSet<Competitions> Competitions { get; set; }

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

        /// <inheritdoc cref="DbContext.OnConfiguring(DbContextOptionsBuilder)"/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
