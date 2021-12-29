namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Person"/>.
/// </summary>
public class PersonBuilder : IEntityTypeConfiguration<Person>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        _ = builder.HasKey(person => person.Id);

        _ = builder.Property(person => person.FirstName).IsRequired().HasMaxLength(128);
        _ = builder.Property(person => person.LastName).IsRequired().HasMaxLength(128);
    }
}
