
namespace Assignment5ABC.ContactFiles
{
    /// <summary>
    /// Represents an address.
    /// </summary>
    internal class Address
    {
        private string street;
        private string zipCode;
        private string city;
        private string country;

        /// <summary>
        /// Gets or sets the street of the address.
        /// </summary>
        public string Street { get => street; set => street = value; }

        /// <summary>
        /// Gets or sets the zip code of the address.
        /// </summary>
        public string ZipCode { get => zipCode; set => zipCode = value; }

        /// <summary>
        /// Gets or sets the city of the address.
        /// </summary>
        public string City { get => city; set => city = value; }

        /// <summary>
        /// Gets or sets the country of the address.
        /// </summary>
        public string Country { get => country; set => country = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified street.
        /// </summary>
        /// <param name="street">The street of the address.</param>
        public Address(string street) : this(street, string.Empty, string.Empty, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified street and zip code.
        /// </summary>
        /// <param name="street">The street of the address.</param>
        /// <param name="zipCode">The zip code of the address.</param>
        public Address(string street, string zipCode) : this(street, zipCode, string.Empty, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified street, zip code, and city.
        /// </summary>
        /// <param name="street">The street of the address.</param>
        /// <param name="zipCode">The zip code of the address.</param>
        /// <param name="city">The city of the address.</param>
        public Address(string street, string zipCode, string city) : this(street, zipCode, city, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified street, zip code, city, and country.
        /// </summary>
        /// <param name="street">The street of the address.</param>
        /// <param name="zipCode">The zip code of the address.</param>
        /// <param name="city">The city of the address.</param>
        /// <param name="country">The country of the address.</param>
        public Address(string street, string zipCode, string city, string country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }
    }
}