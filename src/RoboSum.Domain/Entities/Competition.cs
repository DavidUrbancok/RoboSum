namespace RoboSum.Domain.Entities;

/// <summary>
/// Represents a model of a competition registration.
/// </summary>
public class Competition
{
    /// <summary>
    /// Gets or sets the ID of this entity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a team participates in the 'RoboSum' competition.
    /// </summary>
    public bool RoboSum { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a team participates in the 'RoboCross' competition.
    /// </summary>
    public bool RoboCross { get; set; }

    /// <summary>
    /// Gets or sets the team's registration ID.
    /// </summary>
    public int RegistrationId { get; set; }

    /// <summary>
    /// Gets or sets the team's registration.
    /// </summary>
    public virtual Registration Registration { get; set; }
}
