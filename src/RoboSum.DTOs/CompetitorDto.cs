namespace RoboSum.DTOs
{
    /// <summary>
    /// Represents a Data Transfer Object for a competitor.
    /// </summary>
    public class CompetitorDto : PersonDto
    {
        /// <summary>
        /// Gets or sets the grade of a competitor.
        /// </summary>
        public int Grade { get; set; }
    }
}
