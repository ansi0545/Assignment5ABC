// Contact.cs
namespace Assignment5ABC.ContactFiles
{
    internal class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Email email;
        private Phone phone;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Address Address { get => address; set => address = value; }
        public Email Email { get => email; set => email = value; }
        public Phone Phone { get => phone; set => phone = value; }

        // Constructor
        public Contact()
        {
            Address = new Address();
            Email = new Email();
            Phone = new Phone();
        }

        // Method to perform validation
        public bool CheckData()
        {
            return !string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName) ||
                   !string.IsNullOrEmpty(Address.City) || !string.IsNullOrEmpty(Address.Country);
        }
    }
}
