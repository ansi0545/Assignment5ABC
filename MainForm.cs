using System;
using System.Windows.Forms;
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
            InitializeListView();
        }

        private void SubscribeToEvents()
        {
            btnAddMainForm.Click += btnAddMainForm_Click;
            btnEditMainForm.Click += btnEditMainForm_Click;
            btnDeleteMainForm.Click += btnDeleteMainForm_Click;
            listViewCompleteContact.SelectedIndexChanged += listViewCompleteContact_SelectedIndexChanged;
            listBoxPartialData.SelectedIndexChanged += listBoxPartialData_SelectedIndexChanged;
        }

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
        private void UpdateListView(Customer customer)
        {
            listViewCompleteContact.Items.Clear();
            ListViewItem item = new ListViewItem(customer.ToCompleteString());
            listViewCompleteContact.Items.Add(item);
            ResizeListViewColumns(listViewCompleteContact);
        }

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

        private void btnDeleteMainForm_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected()) return;

            int selectedIndex = listBoxPartialData.SelectedIndex;
            customerManager.RemoveCustomer(selectedIndex);
            UpdateListControls();
        }

        private void listBoxPartialData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPartialData.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < customerManager.Customers.Count)
            {
                Customer selectedCustomer = customerManager.Customers[selectedIndex];
                UpdateListView(selectedCustomer);
            }
        }

        private int GetSelectedIndex()
        {
            return listViewCompleteContact.SelectedIndices.Count > 0 ? listViewCompleteContact.SelectedIndices[0] : -1;
        }

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