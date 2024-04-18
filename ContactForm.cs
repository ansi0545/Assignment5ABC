using Assignment5ABC.ContactFiles;
using System.Text.RegularExpressions;

namespace Assignment5ABC
{
    internal partial class ContactForm : Form
    {
        public Contact Contact { get; private set; }

        public ContactForm()
        {
            InitializeComponent();
            Contact = new Contact(); // Create a new Contact instance
            InitializeCountries();

            // Subscribe to the FormClosing event
            this.FormClosing += ContactForm_FormClosing;

            // Subscribe to the TextChanged event for each TextBox
            txtBoxFirstName.TextChanged += txtBoxFirstName_TextChanged;
            txtBoxLastName.TextChanged += txtBoxLastName_TextChanged;
            txtBoxHomePhoneContactForm.TextChanged += txtBoxHomePhoneContactForm_TextChanged;
            txtBoxCellPhoneContactForm.TextChanged += txtBoxCellPhoneContactForm_TextChanged;
            txtBoxEmailBusinessContactForm.TextChanged += txtBoxEmailBusinessContactForm_TextChanged;
            txtBoxEmailPrivateContactForm.TextChanged += txtBoxEmailPrivateContactForm_TextChanged;
            txtBoxStreet.TextChanged += txtBoxStreet_TextChanged;
            txtBoxCity.TextChanged += txtBoxCity_TextChanged;
            txtBoxZipCode.TextChanged += txtBoxZipCode_TextChanged;

            // Subscribe to the SelectedIndexChanged event for the ComboBox
            comboBoxCountryContactList.SelectedIndexChanged += comboBoxCountryContactList_SelectedIndexChanged;
        }

        public ContactForm(Contact existingContact) : this()
        {
            if (existingContact != null)
            {
                Contact = existingContact;
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

        internal void UpdateFormFields()
        {
            txtBoxFirstName.Text = Contact.FirstName;
            txtBoxLastName.Text = Contact.LastName;
            txtBoxEmailBusinessContactForm.Text = Contact.Email.Work;
            txtBoxEmailPrivateContactForm.Text = Contact.Email.Personal;
            txtBoxCellPhoneContactForm.Text = Contact.Phone.OfficePhone;
            txtBoxHomePhoneContactForm.Text = Contact.Phone.PrivatePhone;
            txtBoxZipCode.Text = Contact.Address.ZipCode;
            txtBoxCity.Text = Contact.Address.City;
            txtBoxStreet.Text = Contact.Address.Street;

            // Find the index of the country in the ComboBox items
            int countryIndex = comboBoxCountryContactList.Items.IndexOf(Contact.Address.Country.Replace("_", " "));
            // Set the SelectedIndex property
            comboBoxCountryContactList.SelectedIndex = countryIndex;
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (!ValidateAndShowErrors())
                {
                    // If the data is not valid, cancel the closing event
                    e.Cancel = true;
                }
            }
        }

        private void btnOKContactForm_Click(object sender, EventArgs e)
        {
            // When the OK button is clicked, validate the contact data
            if (ValidateAndShowErrors())
            {
                // If the data is valid, set the DialogResult to OK and close the form
                this.DialogResult = DialogResult.OK;
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

        internal bool CheckData()
        {

            var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            bool isEmailValid = emailRegex.IsMatch(txtBoxEmailBusinessContactForm.Text) &&
                                emailRegex.IsMatch(txtBoxEmailPrivateContactForm.Text);

            if (!isEmailValid)
            {
                throw new ArgumentException("Invalid email format.");
            }

            return !string.IsNullOrEmpty(txtBoxFirstName.Text) &&
                   !string.IsNullOrEmpty(txtBoxLastName.Text) &&
                   !string.IsNullOrEmpty(txtBoxCity.Text) &&
                   !string.IsNullOrEmpty(comboBoxCountryContactList.Text) &&
                   isEmailValid;
        }

        private bool ValidateAndShowErrors()
        {
            try
            {
                CheckData();
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, Constants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            Contact.FirstName = txtBoxFirstName.Text;
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            Contact.LastName = txtBoxLastName.Text;
        }

        private void txtBoxHomePhoneContactForm_TextChanged(object sender, EventArgs e)
        {
            Contact.Phone.PrivatePhone = txtBoxHomePhoneContactForm.Text;
        }

        private void txtBoxCellPhoneContactForm_TextChanged(object sender, EventArgs e)
        {
            Contact.Phone.OfficePhone = txtBoxCellPhoneContactForm.Text;
        }

        private void txtBoxEmailBusinessContactForm_TextChanged(object sender, EventArgs e)
        {
            Contact.Email.Work = txtBoxEmailBusinessContactForm.Text;
        }

        private void txtBoxEmailPrivateContactForm_TextChanged(object sender, EventArgs e)
        {
            Contact.Email.Personal = txtBoxEmailPrivateContactForm.Text;
        }

        private void txtBoxStreet_TextChanged(object sender, EventArgs e)
        {
            Contact.Address.Street = txtBoxStreet.Text;
        }

        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {
            Contact.Address.City = txtBoxCity.Text;
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            Contact.Address.ZipCode = txtBoxZipCode.Text;
        }

        private void comboBoxCountryContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountryContactList.SelectedItem != null)
            {
                Contact.Address.Country = comboBoxCountryContactList.SelectedItem.ToString().Replace("_", " ");
            }
        }
    }

    public static class Constants
    {
        public const string ErrorTitle = "Error";
        public const string ErrorMessage = "Please fill in all required fields.";
    }
}