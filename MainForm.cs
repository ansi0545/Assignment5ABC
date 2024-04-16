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

            listViewCompleteContact.View = View.Details;
            listViewCompleteContact.Columns.Add("ID", 50);
            listViewCompleteContact.Columns.Add("Name", 150);
            listViewCompleteContact.Columns.Add("Home Phone", 100);
            listViewCompleteContact.Columns.Add("Office Phone", 100);
            listViewCompleteContact.Columns.Add("Work Email", 150);
            listViewCompleteContact.Columns.Add("Personal Email", 150);
            listViewCompleteContact.Columns.Add("Street", 150);
            listViewCompleteContact.Columns.Add("City", 100);
            listViewCompleteContact.Columns.Add("Zip Code", 80);
            listViewCompleteContact.Columns.Add("Country", 100);

            foreach (ColumnHeader column in listViewCompleteContact.Columns)
            {
                column.Width = -1;
            }
        }

        private void SubscribeToEvents()
        {
            btnAddMainForm.Click += btnAddMainForm_Click;
            btnEditMainForm.Click += btnEditMainForm_Click;
            btnDeleteMainForm.Click += btnDeleteMainForm_Click;
            listViewCompleteContact.SelectedIndexChanged += listViewCompleteContact_SelectedIndexChanged;
            listBoxPartialData.SelectedIndexChanged += listBoxPartialData_SelectedIndexChanged;
        }

        private void btnAddMainForm_Click(object sender, EventArgs e)
        {
            using (ContactForm contactForm = new ContactForm())
            {
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer newCustomer = new Customer(contactForm.GetContact());
                    customerManager.AddCustomer(newCustomer);
                    listBoxPartialData.Items.Add(newCustomer.ToString());
                    listViewCompleteContact.Items.Add(new ListViewItem(newCustomer.ToCompleteString()));
                }
            }
        }

        private void btnEditMainForm_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex >= 0)
            {
                using (ContactForm contactForm = new ContactForm(customerManager.Customers[selectedIndex].ContactInfo))
                {
                    if (contactForm.ShowDialog() == DialogResult.OK)
                    {
                        Customer updatedCustomer = customerManager.Customers[selectedIndex];
                        updatedCustomer.ContactInfo = contactForm.GetContact();
                        customerManager.ChangeCustomerData(selectedIndex, updatedCustomer);
                        UpdateListControls();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMainForm_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex >= 0)
            {
                customerManager.RemoveCustomer(selectedIndex);
                UpdateListControls();
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedIndex()
        {
            return listViewCompleteContact.SelectedIndices.Count > 0 ? listViewCompleteContact.SelectedIndices[0] : -1;
        }

        private void UpdateListControls()
        {
            // Clear existing items
            listBoxPartialData.Items.Clear();
            listViewCompleteContact.Items.Clear();

            // Add items to both list controls
            foreach (Customer customer in customerManager.Customers)
            {
                listBoxPartialData.Items.Add(customer.ToString());

                // Create a ListViewItem for the customer using ToCompleteString method
                ListViewItem item = new ListViewItem(customer.ToCompleteString());

                // Add the ListViewItem to the ListView
                listViewCompleteContact.Items.Add(item);
            }

            // Resize columns to fit content
            ResizeListViewColumns(listViewCompleteContact);
        }



        private void ResizeListViewColumns(ListView listView)
        {
            // Auto resize each column
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -1;
            }
        }

        private void listViewCompleteContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex >= 0)
            {
                Customer selectedCustomer = customerManager.Customers[selectedIndex];
                // Update details view or any other controls here
            }
        }

        private void listBoxPartialData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPartialData.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listViewCompleteContact.Items.Count)
            {
                listViewCompleteContact.SelectedIndices.Clear();
                listViewCompleteContact.SelectedIndices.Add(selectedIndex);
            }
        }
    }
}
