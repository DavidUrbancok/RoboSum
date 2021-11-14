namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Address"/>.
/// </summary>
public class AddressBuilder : IEntityTypeConfiguration<Address>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(address => address.Id);

        builder.Property(address => address.Street).IsRequired().HasMaxLength(128);
        builder.Property(address => address.HouseNumber).IsRequired().HasMaxLength(8);
        builder.Property(address => address.City).IsRequired().HasMaxLength(64);
        builder.Property(address => address.ZipCode).IsRequired().HasMaxLength(16);
        builder.Property(address => address.Country).IsRequired().HasMaxLength(64);
    }
}
