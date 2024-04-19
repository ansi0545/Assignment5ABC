using Assignment5ABC.ContactFiles;
using static Assignment5ABC.Helpers.Constants;
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
            id = nextId++;
            ContactInfo = new Contact();
        }

        /// <summary>
        /// Represents a customer.
        /// </summary>
         public Customer(Contact contactInfo)
        {
            if (contactInfo == null)
            {
                throw new ArgumentNullException(nameof(contactInfo));
            }

            id = nextId++;
            ContactInfo = contactInfo;
        }

       
        /// <summary>
        /// Returns a string representation of the customer object.
        /// </summary>
        /// <returns>A string representation of the customer object.</returns>
        public override string ToString()
        {
            if (ContactInfo != null)
            {
                return $"{ID,5} {ContactInfo.LastName,25} {ContactInfo.FirstName,25} {ContactInfo.Phone.OfficePhone,25} {ContactInfo.Email.Work,30}";
            }
            else
            {
                return NoContactInformationAvailable;
            }
        }

        /// <summary>
        /// Returns an array of strings representing the complete information of the customer.
        /// </summary>
        /// <returns>An array of strings containing the customer's ID, full name, phone numbers, email addresses, and address.</returns>
         public string[] ToCompleteString()
        {
            if (ContactInfo == null)
            {
                throw new InvalidOperationException(ContactInfoIsNull);
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