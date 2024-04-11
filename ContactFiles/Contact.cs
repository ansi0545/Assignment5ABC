namespace Assignment5ABC.ContactFiles
{

    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }

        // Constructor
        public Contact()
        {
            Email = new Email();
            Phone = new Phone();
            Address = new Address();
        }

        // Method to perform validation
        public bool CheckData()
        {
            return !string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName) ||
                   !string.IsNullOrEmpty(Address.City) || !string.IsNullOrEmpty(Address.Country);
        }
    }
}