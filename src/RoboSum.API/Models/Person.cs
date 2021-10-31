namespace RoboSum.API.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a model of a person.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the competitor's first name.
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the competitor's last name.
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }
    }
}
