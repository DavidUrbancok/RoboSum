namespace RoboSum.Domain.Entities
{
    /// <summary>
    /// Represents a model of a person.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the competitor's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the competitor's last name.
        /// </summary>
        public string LastName { get; set; }
    }
}
