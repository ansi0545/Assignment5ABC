// CustomerManager.cs
using Assignment5ABC.ContactFiles;
using System.Collections.Generic;

/// <summary>
/// Represents a customer manager that manages a collection of customers.
/// </summary>
namespace Assignment5ABC
{
    internal class CustomerManager
    {
        private List<Customer> customers;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerManager"/> class.
        /// </summary>
        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// Gets the list of customers.
        /// </summary>
        public IReadOnlyList<Customer> Customers => customers;

        /// <summary>
        /// Adds a customer to the customer list.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        /// <summary>
        /// Adds a new customer to the customer list.
        /// </summary>
        /// <param name="contact">The contact information of the customer.</param>
        public void AddCustomer(Contact contact)
        {
            Customer newCustomer = new Customer(contact);
            customers.Add(newCustomer);
        }

        /// <summary>
        /// Removes a customer from the list at the specified index.
        /// </summary>
        /// <param name="index">The index of the customer to remove.</param>
        public void RemoveCustomer(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers.RemoveAt(index);
            }
        }

        /// <summary>
        /// Changes the data of a customer at the specified index.
        /// </summary>
        /// <param name="index">The index of the customer to be changed.</param>
        /// <param name="customer">The new customer data.</param>
        public void ChangeCustomerData(int index, Customer customer)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers[index] = customer;
            }
        }
    }
}
