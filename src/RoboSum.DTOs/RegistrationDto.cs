namespace RoboSum.DTOs;

/// <summary>
/// Represents a Data Transfer Object for a registration.
/// </summary>
public class RegistrationDto
{
    /// <summary>
    /// Gets or sets the ID of this entity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the team that made the registration.
    /// </summary>
    public TeamDto Team { get; set; }

    /// <summary>
    /// Gets or sets the year of the registration.
    /// </summary>
    public int RegistrationYear { get; set; }

    /// <summary>
    /// Gets or sets the remarks of the registration.
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// Gets or sets the competitions in which the registering team participates.
    /// </summary>
    public CompetitionDto Competitions { get; set; }
}
