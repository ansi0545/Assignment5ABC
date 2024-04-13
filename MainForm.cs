

using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager;
        private ContactForm contactForm;

        public MainForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            contactForm = new ContactForm(); // Initialize ContactForm instance
            btnAddMainForm.Click += btnAddMainForm_Click;
            btnEditMainForm.Click += btnEditMainForm_Click;
            btnDeleteMainForm.Click += btnDeleteMainForm_Click;
        }

        private void btnAddMainForm_Click(object sender, EventArgs e)
        {
            // Show ContactForm
            ContactForm contactForm = new ContactForm();
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                // Retrieve contact data from ContactForm
                Contact contact = contactForm.GetContact();

                // Create a new customer with the retrieved contact data
                Customer newCustomer = new Customer(contact);

                // Add the new customer to customerManager
                customerManager.AddCustomer(newCustomer);

                // Add the new customer to listBoxPartialData
                listBoxPartialData.Items.Add(newCustomer);
            }
        }


        private void btnEditMainForm_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCompleteContact.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ContactForm contactForm = new ContactForm(customerManager.Customers[selectedIndex].ContactInfo);
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer updatedCustomer = customerManager.Customers[selectedIndex];
                    updatedCustomer.ContactInfo = contactForm.GetContact();
                    customerManager.ChangeCustomerData(selectedIndex, updatedCustomer);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeleteMainForm_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCompleteContact.SelectedIndex;
            if (selectedIndex >= 0)
            {
                customerManager.RemoveCustomer(selectedIndex); // Pass index instead of customer object
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBoxCompleteContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add code here to handle the event
        }

        private void listBoxPartialData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add code here to handle the event
        }


    }
}
