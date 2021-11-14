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
        builder.HasKey(registration => registration.Id);

        builder.Property(registration => registration.RegistrationYear).IsRequired();

        builder
            .HasOne(registration => registration.Team)
            .WithOne(team => team.Registration)
            .HasForeignKey<Registration>(registration => registration.TeamId);

        builder
            .HasOne(registration => registration.Competition)
            .WithOne(competition => competition.Registration)
            .HasForeignKey<Registration>(registration => registration.CompetitionId);
    }
}
