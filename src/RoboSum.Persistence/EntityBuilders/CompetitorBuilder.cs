namespace RoboSum.Persistence.EntityBuilders
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoboSum.Domain.Entities;

    /// <summary>
    /// Represents an entity builder for <see cref="Competitor"/>.
    /// </summary>
    public class CompetitorBuilder : IEntityTypeConfiguration<Competitor>
    {
        /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
        public void Configure(EntityTypeBuilder<Competitor> builder)
        {
            builder.Property(competitor => competitor.Grade).IsRequired();
        }
    }
}
