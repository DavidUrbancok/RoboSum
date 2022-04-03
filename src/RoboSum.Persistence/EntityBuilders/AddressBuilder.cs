namespace RoboSum.Persistence.SQL.EntityBuilders;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/// <summary>
/// Represents an entity builder for <see cref="Address"/>.
/// </summary>
public class AddressBuilder : IEntityTypeConfiguration<Address>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        _ = builder.HasKey(address => address.Id);

        _ = builder.Property(address => address.Street).IsRequired().HasMaxLength(128);
        _ = builder.Property(address => address.HouseNumber).IsRequired().HasMaxLength(8);
        _ = builder.Property(address => address.City).IsRequired().HasMaxLength(64);
        _ = builder.Property(address => address.ZipCode).IsRequired().HasMaxLength(16);
        _ = builder.Property(address => address.Country).IsRequired().HasMaxLength(64);
    }
}
