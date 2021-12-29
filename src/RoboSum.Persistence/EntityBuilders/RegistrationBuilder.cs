namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Registration"/>.
/// </summary>
public class RegistrationBuilder : IEntityTypeConfiguration<Registration>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Registration> builder)
    {
        _ = builder.HasKey(registration => registration.Id);

        _ = builder.Property(registration => registration.RegistrationYear).IsRequired();

        _ = builder
            .HasOne(registration => registration.Team)
            .WithOne(team => team.Registration)
            .HasForeignKey<Registration>(registration => registration.TeamId);

        _ = builder
            .HasOne(registration => registration.Competition)
            .WithOne(competition => competition.Registration)
            .HasForeignKey<Registration>(registration => registration.CompetitionId);
    }
}
