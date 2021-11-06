namespace RoboSum.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a model of a competitor.
    /// </summary>
    public class Competitor : Person
    {
        /// <summary>
        /// Gets or sets the grade of a competitor.
        /// </summary>
        [Required]
        public int Grade { get; set; }
    }
}
