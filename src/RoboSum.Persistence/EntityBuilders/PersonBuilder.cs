namespace RoboSum.Persistence.EntityBuilders
{
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
            builder.HasKey(person => person.Id);

            builder.Property(person => person.FirstName).IsRequired().HasMaxLength(128);
            builder.Property(person => person.LastName).IsRequired().HasMaxLength(128);
        }
    }
}
