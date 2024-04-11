// Customer.cs
using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    internal class Customer
    {
        private string id;
        private Contact contactInfo;

        public string ID { get => id; set => id = value; }
        public Contact ContactInfo { get => contactInfo; set => contactInfo = value; }

        // Constructor
        public Customer()
        {
            ContactInfo = new Contact();
        }
    }
}
