namespace RoboSum.Models
{
    /// <summary>
    /// Represents a model of a registration of a team.
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the team that made the registration.
        /// </summary>
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the year of the registration.
        /// </summary>
        public int RegistrationYear { get; set; }

        /// <summary>
        /// Gets or sets the remarks of the registration.
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or sets the competitions in which the registering team participates.
        /// </summary>
        public Competitions Competitions { get; set; }
    }
}
