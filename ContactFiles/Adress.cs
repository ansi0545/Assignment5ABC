// Address.cs
namespace Assignment5ABC.ContactFiles
{
    internal class Address
    {
        private string street;
        private string zipCode;
        private string city;
        private string country;

        public string Street { get => street; set => street = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        // Constructors
        public Address() : this("Default Street", "Default ZipCode", "Default City", "Default Country") { }

        public Address(string street) : this(street, "Default ZipCode", "Default City", "Default Country") { }

        public Address(string street, string zipCode) : this(street, zipCode, "Default City", "Default Country") { }

        public Address(string street, string zipCode, string city) : this(street, zipCode, city, "Default Country") { }

        public Address(string street, string zipCode, string city, string country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }
    }
}