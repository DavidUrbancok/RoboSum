namespace RoboSum.Persistence.PostgreSQL;

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SQL;

/// <summary>
/// Represents a DB context for the <see cref="RoboSum"/> project.
/// </summary>
public class RoboSumContext : AbstractDbContext
{
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="RoboSumContext"/> class.
    /// </summary>
    /// <param name="configuration">The application configuration.</param>
    /// <exception cref="ArgumentNullException">Thrown, when <paramref name="configuration"/> is <see langword="null"/>.</exception>
    public RoboSumContext(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <inheritdoc cref="DbContext.OnConfiguring(DbContextOptionsBuilder)"/>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        _ = optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }
}
