namespace RoboSum.Domain.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a model of a team.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the team's contact email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the team's school ID.
        /// </summary>
        public int SchoolId { get; set; }

        /// <summary>
        /// Gets or sets the team's school.
        /// </summary>
        public virtual School School { get; set; }

        /// <summary>
        /// Gets or sets the team's teacher ID.
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// Gets or sets the team's teacher.
        /// </summary>
        public virtual Teacher Teacher { get; set; }

        /// <summary>
        /// Gets or sets the team's competitors.
        /// </summary>
        public virtual ICollection<Competitor> Competitors { get; set; }
    }
}
