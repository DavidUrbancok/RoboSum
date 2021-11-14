namespace RoboSum.Domain.Entities;

using System.Collections.Generic;

/// <summary>
/// Represents a model of a teacher.
/// </summary>
public class Teacher : Person
{
    /// <summary>
    /// Gets or sets the teacher's school ID.
    /// </summary>
    public int SchoolId { get; set; }

    /// <summary>
    /// Gets or sets the teacher's school.
    /// </summary>
    public virtual School School { get; set; }

    /// <summary>
    /// Gets or sets the teacher's teams.
    /// </summary>
    public virtual ICollection<Team> Teams { get; set; }
}
