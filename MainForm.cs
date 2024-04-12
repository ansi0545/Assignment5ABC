

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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                Customer newCustomer = new Customer();
                newCustomer.ContactInfo = contactForm.GetContact(); // Use GetContact method to retrieve contact
                customerManager.AddCustomer(newCustomer);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCompleteContact.SelectedIndex;
            if (selectedIndex >= 0)
            {
                contactForm.SetContact(customerManager.Customers[selectedIndex].ContactInfo); // Pass existing contact to SetContact method
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer updatedCustomer = customerManager.Customers[selectedIndex]; // Get the selected customer
                    updatedCustomer.ContactInfo = contactForm.GetContact(); // Update the contact info
                    customerManager.ChangeCustomerData(selectedIndex, updatedCustomer); // Pass the updated customer to ChangeCustomerData method
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
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
