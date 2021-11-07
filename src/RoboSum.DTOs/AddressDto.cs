﻿namespace RoboSum.DTOs
{
    /// <summary>
    /// Represents a Data Transfer Object for an address.
    /// </summary>
    public class AddressDto
    {
        /// <summary>
        /// Gets or sets the ID of this entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the address' street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the address' house number.
        /// </summary>
        /// <remarks>
        /// It is a type of <see cref="string"/> to accept values such as '123A'.
        /// </remarks>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the address' street.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the address' ZIP code.
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the address' country.
        /// </summary>
        public string Country { get; set; }
    }
}