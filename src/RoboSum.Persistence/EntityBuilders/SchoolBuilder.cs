namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="School"/>.
/// </summary>
public class SchoolBuilder : IEntityTypeConfiguration<School>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder.HasKey(school => school.Id);

        builder.Property(school => school.Name).IsRequired().HasMaxLength(128);

        builder
            .HasOne(school => school.Address)
            .WithOne(address => address.School)
            .HasForeignKey<Address>(address => address.SchoolId);

        builder
            .HasMany(school => school.Teams)
            .WithOne(team => team.School)
            .HasForeignKey(team => team.SchoolId);
    }
}
