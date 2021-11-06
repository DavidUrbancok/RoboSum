namespace RoboSum.DTOs
{
    /// <summary>
    /// Represents a Data Transfer Object for a team.
    /// </summary>
    public class TeamDto
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
        public SchoolDto School { get; set; }

        /// <summary>
        /// Gets or sets the team's teacher.
        /// </summary>
        public TeacherDto Teacher { get; set; }

        /// <summary>
        /// Gets or sets the team's competitors.
        /// </summary>
        public ICollection<CompetitorDto> Competitors { get; set; }
    }
}
