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
            id = nextId++; // Assign ID and increment for the next customer
            ContactInfo = contactInfo;
        }

        // Override ToString method to display customer information
        public override string ToString()
        {
            if (ContactInfo != null)
            {
                return string.Format("{0,5} {1,25} {2,25} {3,25} {4,30}", ID, ContactInfo.LastName, ContactInfo.FirstName, ContactInfo.Phone.OfficePhone, ContactInfo.Email.Work);
            }
            else
            {
                return "No Contact Information Available";
            }
        }

        public string[] ToCompleteString()
        {
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