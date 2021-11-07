namespace RoboSum.Domain.Entities
{
    using System.Collections.Generic;

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

        /// <summary>
        /// Gets or sets the school's teams.
        /// </summary>
        public virtual ICollection<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the school's teachers.
        /// </summary>
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
