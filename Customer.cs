﻿using Assignment5ABC.ContactFiles;
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
            return string.Format("{0}                 {1}                 {2}                {3}                 {4}", ID, ContactInfo.LastName, ContactInfo.FirstName, ContactInfo.Phone.OfficePhone, ContactInfo.Email.Work);
            }
            else
            {
            return "No Contact Information Available";
            }
        }
    }
}
