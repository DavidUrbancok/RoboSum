namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Competition"/>.
/// </summary>
public class CompetitionBuilder : IEntityTypeConfiguration<Competition>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Competition> builder)
    {
        _ = builder.HasKey(competition => competition.Id);
    }
}
