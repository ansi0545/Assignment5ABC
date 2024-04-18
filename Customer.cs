using Assignment5ABC.ContactFiles;
using System;

namespace Assignment5ABC
{
    internal class Customer
    {
        private static int nextId = 1; // Static variable to generate unique IDs for customers
        private int id;
        private Contact contactInfo;

        // Properties
        public int ID { get => id; }
        public Contact ContactInfo { get => contactInfo; set => contactInfo = value; }

        // Constructor
        public Customer()
        {
            id = nextId++; // Assign ID and increment for the next customer
            ContactInfo = new Contact();
        }
        public Customer(Contact contactInfo)
        {
            if (contactInfo == null)
            {
                throw new ArgumentNullException(nameof(contactInfo));
            }

            id = nextId++;
            ContactInfo = contactInfo;
        }

        // Override ToString method to display customer information
        public override string ToString()
        {
            if (ContactInfo != null)
            {
                return $"{ID,5} {ContactInfo.LastName,25} {ContactInfo.FirstName,25} {ContactInfo.Phone.OfficePhone,25} {ContactInfo.Email.Work,30}";
            }
            else
            {
                return "No Contact Information Available";
            }
        }

        public string[] ToCompleteString()
        {
            if (ContactInfo == null)
            {
                throw new InvalidOperationException("ContactInfo is null.");
            }

            return new string[]
            {
        ID.ToString(),
        $"{ContactInfo.FirstName} {ContactInfo.LastName}",
        ContactInfo.Phone.PrivatePhone,
        ContactInfo.Phone.OfficePhone,
        ContactInfo.Email.Work,
        ContactInfo.Email.Personal,
        ContactInfo.Address.Street,
        ContactInfo.Address.City,
        ContactInfo.Address.ZipCode,
        ContactInfo.Address.Country
            };
        }
    }
}