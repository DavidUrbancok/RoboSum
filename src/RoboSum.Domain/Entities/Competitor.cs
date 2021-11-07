namespace RoboSum.Domain.Entities
{
    /// <summary>
    /// Represents a model of a competitor.
    /// </summary>
    public class Competitor : Person
    {
        /// <summary>
        /// Gets or sets the grade of a competitor.
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Gets or sets the competitor's team ID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or sets the competitor's team.
        /// </summary>
        public virtual Team Team { get; set; }
    }
}
