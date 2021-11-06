namespace RoboSum.Domain.Entities
{
    /// <summary>
    /// Represents a model of a school.
    /// </summary>
    public class School
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the school's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the school's address ID.
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the school's address.
        /// </summary>
        public virtual Address Address { get; set; }
    }
}
