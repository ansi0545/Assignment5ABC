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
            contactForm = new ContactForm();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            btnAddMainForm.Click += btnAddMainForm_Click;
            btnEditMainForm.Click += btnEditMainForm_Click;
            btnDeleteMainForm.Click += btnDeleteMainForm_Click;
        }

        private void btnAddMainForm_Click(object sender, EventArgs e)
        {
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                Customer newCustomer = new Customer(contactForm.GetContact());
                customerManager.AddCustomer(newCustomer);
                listBoxPartialData.Items.Add(newCustomer);
                listBoxCompleteContact.Items.Add(newCustomer.ToCompleteString());
            }
        }

        private void btnEditMainForm_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCompleteContact.SelectedIndex;
            if (selectedIndex >= 0)
            {
                contactForm.SetContact(customerManager.Customers[selectedIndex].ContactInfo);
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer updatedCustomer = customerManager.Customers[selectedIndex];
                    updatedCustomer.ContactInfo = contactForm.GetContact();
                    customerManager.ChangeCustomerData(selectedIndex, updatedCustomer);
                    listBoxCompleteContact.Items[selectedIndex] = updatedCustomer.ToCompleteString();
                    listBoxPartialData.Items[selectedIndex] = updatedCustomer.ToString();
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
                customerManager.RemoveCustomer(selectedIndex);
                listBoxCompleteContact.Items.RemoveAt(selectedIndex);
                listBoxPartialData.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxCompleteContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCompleteContact.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Customer selectedCustomer = customerManager.Customers[selectedIndex];
                // Display the contact info in a separate control
                // For example, if lblContactInfo is a Label:
                listBoxCompleteContact.Text = selectedCustomer.ContactInfo.ToString();
            }
        }

        private void listBoxPartialData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPartialData.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listBoxCompleteContact.Items.Count)
            {
                listBoxCompleteContact.SelectedIndex = selectedIndex;
            }
        }
    }
}