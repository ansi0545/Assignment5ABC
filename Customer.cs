using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{

    internal class Customer
    {
        public string ID { get; set; }
        public Contact ContactInfo { get; set; }

        // Constructor
        public Customer()
        {
            ContactInfo = new Contact();
        }
    }
}