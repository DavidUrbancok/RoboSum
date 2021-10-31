namespace RoboSum.API.Models
{
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
        /// Gets or sets the team's school.
        /// </summary>
        public School School { get; set; }

        /// <summary>
        /// Gets or sets the team's teacher.
        /// </summary>
        public Teacher Teacher { get; set; }

        /// <summary>
        /// Gets or sets the team's competitors.
        /// </summary>
        public ICollection<Competitor> Competitors { get; set; }
    }
}