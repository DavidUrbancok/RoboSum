namespace RoboSum.DTOs;

/// <summary>
/// Represents a Data Transfer Object for a school.
/// </summary>
public class SchoolDto
{
    /// <summary>
    /// Gets or sets the ID of this entity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the school's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the school's address.
    /// </summary>
    public AddressDto Address { get; set; }
}
