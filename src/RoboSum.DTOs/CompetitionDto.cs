﻿namespace RoboSum.DTOs
{
    /// <summary>
    /// Represents a Data Transfer Object for a competition registration.
    /// </summary>
    public class CompetitionDto
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a team participates in the 'RoboSum' competition.
        /// </summary>
        public bool RoboSum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a team participates in the 'RoboCross' competition.
        /// </summary>
        public bool RoboCross { get; set; }
    }
}