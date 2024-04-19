using Assignment5ABC.ContactFiles;
using Assignment5ABC.Helpers;


namespace Assignment5ABC
{
    internal partial class ContactForm : Form
    {
        public Contact Contact { get; private set; }

        #region Constructors
        public ContactForm()
        {
            InitializeComponent();
            Contact = new Contact();
            InitializeCountries();
            SubscribeToEvents();
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
            this.Text = title;
        }
        #endregion

        #region Initialization Methods
        private void InitializeCountries()
        {
            foreach (var country in Enum.GetValues(typeof(Assignment5ABC.ContactFiles.Countries)))
            {
                comboBoxCountryContactList.Items.Add(country.ToString().Replace("_", " "));
            }
        }

        private void SubscribeToEvents()
        {
            this.FormClosing += ContactForm_FormClosing;
            txtBoxFirstName.TextChanged += txtBoxFirstName_TextChanged;
            txtBoxLastName.TextChanged += txtBoxLastName_TextChanged;
            txtBoxHomePhoneContactForm.TextChanged += txtBoxHomePhoneContactForm_TextChanged;
            txtBoxCellPhoneContactForm.TextChanged += txtBoxCellPhoneContactForm_TextChanged;
            txtBoxEmailBusinessContactForm.TextChanged += txtBoxEmailBusinessContactForm_TextChanged;
            txtBoxEmailPrivateContactForm.TextChanged += txtBoxEmailPrivateContactForm_TextChanged;
            txtBoxStreet.TextChanged += txtBoxStreet_TextChanged;
            txtBoxCity.TextChanged += txtBoxCity_TextChanged;
            txtBoxZipCode.TextChanged += txtBoxZipCode_TextChanged;
            comboBoxCountryContactList.SelectedIndexChanged += comboBoxCountryContactList_SelectedIndexChanged;
        }
        #endregion

        #region Form Field Methods
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
            comboBoxCountryContactList.SelectedIndex = -1;
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

            int countryIndex = comboBoxCountryContactList.Items.IndexOf(Contact.Address.Country.Replace("_", " "));
            comboBoxCountryContactList.SelectedIndex = countryIndex;
        }
        #endregion

        #region Event Handlers
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && !ValidateAndShowErrors())
            {
                e.Cancel = true;
            }
        }

        private void btnOKContactForm_Click(object sender, EventArgs e)
        {
            TryCloseForm();
        }

        private void btnCancelContactForm_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion

        #region Validation Methods
        internal bool CheckData()
        {
            Validator.ValidateEmailFormat(txtBoxEmailBusinessContactForm.Text);
            Validator.ValidateEmailFormat(txtBoxEmailPrivateContactForm.Text);

            Validator.ValidateNotEmpty(txtBoxFirstName.Text, Constants.ErrorMessage);
            Validator.ValidateNotEmpty(txtBoxLastName.Text, Constants.ErrorMessage);
            Validator.ValidateNotEmpty(txtBoxCity.Text, Constants.ErrorMessage);
            Validator.ValidateNotEmpty(comboBoxCountryContactList.Text, Constants.ErrorMessage);

            return true;
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
        private void TryCloseForm()
        {
            if (ValidateAndShowErrors())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        #endregion

        #region Text Changed Event Handlers
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
        #endregion
    }
}