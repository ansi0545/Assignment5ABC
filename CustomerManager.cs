﻿// CustomerManager.cs
using Assignment5ABC.ContactFiles;
using System.Collections.Generic;

namespace Assignment5ABC
{
    internal class CustomerManager
    {
        private List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        public IReadOnlyList<Customer> Customers => customers;

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddCustomer(Contact contact)
        {
            Customer newCustomer = new Customer(contact);
            customers.Add(newCustomer);
        }

        public void RemoveCustomer(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers.RemoveAt(index);
            }
        }

        public void ChangeCustomerData(int index, Customer customer)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers[index] = customer;
            }
        }
    }
}
