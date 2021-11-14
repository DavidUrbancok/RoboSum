namespace RoboSum.DTOs;

/// <summary>
/// Represents a Data Transfer Object for a person.
/// </summary>
public class PersonDto
{
    /// <summary>
    /// Gets or sets the ID of this entity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the competitor's first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the competitor's last name.
    /// </summary>
    public string LastName { get; set; }
}
