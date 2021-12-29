namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Team"/>.
/// </summary>
public class TeamBuilder : IEntityTypeConfiguration<Team>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        _ = builder.HasKey(team => team.Id);

        _ = builder.Property(team => team.Email).IsRequired().HasMaxLength(128);

        _ = builder
            .HasOne(team => team.Registration)
            .WithOne(registration => registration.Team)
            .HasForeignKey<Team>(team => team.RegistrationId);

        _ = builder
            .HasOne(team => team.School)
            .WithMany(school => school.Teams)
            .HasForeignKey(team => team.SchoolId);

        _ = builder
            .HasOne(team => team.Teacher)
            .WithMany(teacher => teacher.Teams)
            .HasForeignKey(team => team.TeacherId);

        _ = builder
            .HasMany(team => team.Competitors)
            .WithOne(competitor => competitor.Team)
            .HasForeignKey(competitor => competitor.TeamId);
    }
}
