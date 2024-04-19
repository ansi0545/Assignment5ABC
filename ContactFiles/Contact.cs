// Contact.cs
namespace Assignment5ABC.ContactFiles
{
    /// <summary>
    /// Represents a contact with personal information.
    /// </summary>
    internal class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Email email;
        private Phone phone;

        /// <summary>
        /// Gets or sets the first name of the contact.
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }

        /// <summary>
        /// Gets or sets the last name of the contact.
        /// </summary>
        public string LastName { get => lastName; set => lastName = value; }

        /// <summary>
        /// Gets or sets the address of the contact.
        /// </summary>
        public Address Address { get => address; set => address = value; }

        /// <summary>
        /// Gets or sets the email of the contact.
        /// </summary>
        public Email Email { get => email; set => email = value; }

        /// <summary>
        /// Gets or sets the phone number of the contact.
        /// </summary>
        public Phone Phone { get => phone; set => phone = value; }

        //constructor
        public Contact()
        {
            Address = new Address();
            Email = new Email();
            Phone = new Phone();
        }

        /// <summary>
        /// Returns a string representation of the contact.
        /// </summary>
        /// <returns>A string containing the contact's information.</returns>
         public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Home Phone: {Phone.PrivatePhone}, Office Phone: {Phone.OfficePhone}, Email (Work): {Email.Work}, Email (Personal): {Email.Personal}, Street: {Address.Street}, City: {Address.City}, Zip Code: {Address.ZipCode}, Country: {Address.Country}";
        }
    }
}
