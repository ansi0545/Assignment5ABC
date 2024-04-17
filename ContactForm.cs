
using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    internal partial class ContactForm : Form
    {
        private Contact contact;

        public ContactForm()
        {
            InitializeComponent();
            contact = new Contact(); // Create a new Contact instance
            InitializeCountries();

            // Subscribe to the FormClosing event
            this.FormClosing += ContactForm_FormClosing;
        }

        public ContactForm(Contact existingContact) : this()
        {
            if (existingContact != null)
            {
                contact = existingContact; // Use existing contact when editing
                UpdateFormFields();
            }
        }

        public ContactForm(Contact existingContact, string title) : this(existingContact)
        {
            this.Text = title; // Set the form title
        }

        private void InitializeCountries()
        {
            foreach (var country in Enum.GetValues(typeof(Assignment5ABC.ContactFiles.Countries)))
            {
                comboBoxCountryContactList.Items.Add(country.ToString().Replace("_", " "));
            }
        }

        public void ClearFields()
        {
            txtBoxLastName.Clear();
            txtBoxFirstName.Clear();
            txtBoxEmailBusinessContactForm.Clear();
            txtBoxEmailPrivateContactForm.Clear();
            txtBoxCellPhoneContactForm.Clear();
            txtBoxHomePhoneContactForm.Clear();
            txtBoxZipCode.Clear();
            txtBoxCity.Clear();
            txtBoxStreet.Clear();
            comboBoxCountryContactList.SelectedIndex = -1; // Reset the combo box
        }

        private Contact _contact;

        public Contact Contact
        {
            get { return _contact; }
            private set { _contact = value; }
        }

        internal void UpdateFormFields()
        {
            txtBoxFirstName.Text = contact.FirstName;
            txtBoxLastName.Text = contact.LastName;
            txtBoxEmailBusinessContactForm.Text = contact.Email.Work;
            txtBoxEmailPrivateContactForm.Text = contact.Email.Personal;
            txtBoxCellPhoneContactForm.Text = contact.Phone.OfficePhone;
            txtBoxHomePhoneContactForm.Text = contact.Phone.PrivatePhone;
            txtBoxZipCode.Text = contact.Address.ZipCode;
            txtBoxCity.Text = contact.Address.City;
            txtBoxStreet.Text = contact.Address.Street;

            // Find the index of the country in the ComboBox items
            int countryIndex = comboBoxCountryContactList.Items.IndexOf(contact.Address.Country.Replace("_", " "));
            // Set the SelectedIndex property
            comboBoxCountryContactList.SelectedIndex = countryIndex;
        }

        internal void SetContact(Contact existingContact)
        {
            contact = existingContact; // Set the Contact object
            UpdateFormFields();
        }

        internal Contact GetContact()
        {
            // Update the contact information from the form fields
            contact.FirstName = txtBoxFirstName.Text;
            contact.LastName = txtBoxLastName.Text;
            contact.Phone.PrivatePhone = txtBoxHomePhoneContactForm.Text;
            contact.Phone.OfficePhone = txtBoxCellPhoneContactForm.Text;
            contact.Email.Work = txtBoxEmailBusinessContactForm.Text;
            contact.Email.Personal = txtBoxEmailPrivateContactForm.Text;
            contact.Address.Street = txtBoxStreet.Text;
            contact.Address.City = txtBoxCity.Text;
            contact.Address.ZipCode = txtBoxZipCode.Text;
            if (comboBoxCountryContactList.SelectedItem != null)
            {
                contact.Address.Country = comboBoxCountryContactList.SelectedItem.ToString().Replace("_", " ");
            }

            return contact;
        }





        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.DialogResult == DialogResult.OK)
            {

                if (!CheckData())
                {
                    // If the data is not valid, cancel the closing event
                    e.Cancel = true;
                    // Show an error message
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOKContactForm_Click(object sender, EventArgs e)
        {
            // When the OK button is clicked, validate the contact data
            if (CheckData())
            {
                // If the data is valid, set the DialogResult to OK and close the form
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                // If the data is not valid, show an error message
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelContactForm_Click(object sender, EventArgs e)
        {
            // When the Cancel button is clicked, confirm the cancellation
            var result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // If the user confirms, set the DialogResult to Cancel and close the form
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }




        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            contact.FirstName = txtBoxFirstName.Text;
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            contact.LastName = txtBoxLastName.Text;
        }

        private void txtBoxHomePhoneContactForm_TextChanged(object sender, EventArgs e)
        {
            contact.Phone.PrivatePhone = txtBoxHomePhoneContactForm.Text;
        }

        private void txtBoxCellPhoneContactForm_TextChanged(object sender, EventArgs e)
        {
            contact.Phone.OfficePhone = txtBoxCellPhoneContactForm.Text;
        }

        private void txtBoxEmailBusinessContactForm_TextChanged(object sender, EventArgs e)
        {
            contact.Email.Work = txtBoxEmailBusinessContactForm.Text;
        }

        private void txtBoxEmailPrivateContactForm_TextChanged(object sender, EventArgs e)
        {
            contact.Email.Personal = txtBoxEmailPrivateContactForm.Text;
        }

        private void txtBoxStreet_TextChanged(object sender, EventArgs e)
        {
            contact.Address.Street = txtBoxStreet.Text;
        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {
            contact.Address.City = txtBoxCity.Text;
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            contact.Address.ZipCode = txtBoxZipCode.Text;
        }

        private void comboBoxCountryContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountryContactList.SelectedItem != null)
            {
                contact.Address.Country = comboBoxCountryContactList.SelectedItem.ToString().Replace("_", " ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        internal bool CheckData()
        {
            // Check if all fields (first name, last name, city, and country) are provided
            return !string.IsNullOrEmpty(txtBoxFirstName.Text) &&
                   !string.IsNullOrEmpty(txtBoxLastName.Text) &&
                   !string.IsNullOrEmpty(txtBoxCity.Text) &&
                   !string.IsNullOrEmpty(comboBoxCountryContactList.Text);
        }

    }
}

