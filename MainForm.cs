using System;
using System.Windows.Forms;
using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager;
        private ContactForm contactForm;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
         public MainForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            contactForm = new ContactForm();
            SubscribeToEvents();
            InitializeListView();
        }

        /// <summary>
        /// Subscribes to the events of the main form controls.
        /// </summary>
        private void SubscribeToEvents()
        {
            btnAddMainForm.Click += btnAddMainForm_Click;
            btnEditMainForm.Click += btnEditMainForm_Click;
            btnDeleteMainForm.Click += btnDeleteMainForm_Click;
            listViewCompleteContact.SelectedIndexChanged += listViewCompleteContact_SelectedIndexChanged;
            listBoxPartialData.SelectedIndexChanged += listBoxPartialData_SelectedIndexChanged;
        }

        /// <summary>
        /// Initializes the ListView control with the necessary columns and settings.
        /// </summary>
        private void InitializeListView()
        {
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
        /// <summary>
        /// Checks if a customer is selected in the list box.
        /// </summary>
        /// <returns>True if a customer is selected, otherwise false.</returns>
         private bool CheckCustomerSelected()
        {
            int selectedIndex = listBoxPartialData.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Updates the ListView control with the provided customer information.
        /// </summary>
        /// <param name="customer">The customer object containing the information to be displayed.</param>
         private void UpdateListView(Customer customer)
        {
            listViewCompleteContact.Items.Clear();
            ListViewItem item = new ListViewItem(customer.ToCompleteString());
            listViewCompleteContact.Items.Add(item);
            ResizeListViewColumns(listViewCompleteContact);
        }

        /// <summary>
        /// Event handler for the click event of the "Add" button on the main form.
        /// Opens a contact form to add a new customer and updates the list controls if the operation is successful.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddMainForm_Click(object sender, EventArgs e)
        {
            using (ContactForm contactForm = new ContactForm(null, "Add new customer"))
            {
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    customerManager.AddCustomer(contactForm.Contact);
                    UpdateListControls();
                }
            }
        }

        /// <summary>
        /// Event handler for the "Edit" button click event in the main form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> object that contains the event data.</param>
        private void btnEditMainForm_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected()) return;

            int selectedIndex = listBoxPartialData.SelectedIndex;
            using (ContactForm contactForm = new ContactForm(customerManager.Customers[selectedIndex].ContactInfo, "Edit customer"))
            {
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer updatedCustomer = customerManager.Customers[selectedIndex];
                    updatedCustomer.ContactInfo = contactForm.Contact;
                    customerManager.ChangeCustomerData(selectedIndex, updatedCustomer);
                    UpdateListControls();
                }
            }
        }

        /// <summary>
        /// Event handler for the click event of the "Delete" button on the main form.
        /// Removes the selected customer from the customer manager and updates the list controls.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void btnDeleteMainForm_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected()) return;

            int selectedIndex = listBoxPartialData.SelectedIndex;
            customerManager.RemoveCustomer(selectedIndex);
            UpdateListControls();
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the listBoxPartialData control.
        /// Updates the ListView control with the data of the selected customer.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
         private void listBoxPartialData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPartialData.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < customerManager.Customers.Count)
            {
                Customer selectedCustomer = customerManager.Customers[selectedIndex];
                UpdateListView(selectedCustomer);
            }
        }

        /// <summary>
        /// Gets the index of the selected item in the listViewCompleteContact control.
        /// </summary>
        /// <returns>The index of the selected item, or -1 if no item is selected.</returns>
         private int GetSelectedIndex()
        {
            return listViewCompleteContact.SelectedIndices.Count > 0 ? listViewCompleteContact.SelectedIndices[0] : -1;
        }

        /// <summary>
        /// Updates the list controls by populating the listBoxPartialData and listViewCompleteContact controls with customer data.
        /// </summary>
        private void UpdateListControls()
        {
            listBoxPartialData.Items.Clear();
            listViewCompleteContact.Items.Clear();
            foreach (Customer customer in customerManager.Customers)
            {
                listBoxPartialData.Items.Add(customer.ToString());
            }

            ResizeListViewColumns(listViewCompleteContact);
        }

        /// <summary>
        /// Resizes the columns of a ListView control to fit the content.
        /// </summary>
        /// <param name="listView">The ListView control to resize.</param>
        private void ResizeListViewColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                listView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.HeaderSize);
                int width1 = column.Width;
                listView.AutoResizeColumn(column.Index, ColumnHeaderAutoResizeStyle.ColumnContent);
                int width2 = column.Width;
                column.Width = Math.Max(width1, width2);
            }
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the listViewCompleteContact control.
        /// Retrieves the selected index from the listViewCompleteContact control and retrieves the corresponding Customer object from the customerManager.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void listViewCompleteContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex >= 0)
            {
                Customer selectedCustomer = customerManager.Customers[selectedIndex];
            }
        }

    }
}