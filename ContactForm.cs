﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            foreach (var country in Enum.GetValues(typeof(Assignment5ABC.ContactFiles.Countries)))
            {
                comboBoxCountryContactList.Items.Add(country.ToString().Replace("_", " "));
            }
        }

        public ContactForm(Contact existingContact) : this()
        {
            contact = existingContact; // Use existing contact when editing
            UpdateFormFields();
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
            // Update other form fields similarly
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
            contact.Address.ZipCode = txtBoxCity.Text;
            contact.Address.City = txtBoxZipCode.Text;
            contact.Address.Country = comboBoxCountryContactList.SelectedItem.ToString().Replace("_", " ");

            return contact;
        }

        // Add event handlers for other form controls as necessary

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
        private void btnOKContactForm_Click(object sender, EventArgs e)
        {
            // When the OK button is clicked, validate the contact data
            if (contact.CheckData())
            {
                // If the data is valid, set the DialogResult to OK and close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // If the data is not valid, show an error message
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            contact.Address.ZipCode = txtBoxCity.Text;
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            contact.Address.City = txtBoxZipCode.Text;
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
            // Check if at least a first name, or a last name, city and country are provided
            // For example:
            return !string.IsNullOrEmpty(txtBoxFirstName.Text) || !string.IsNullOrEmpty(txtBoxLastName.Text) && !string.IsNullOrEmpty(txtBoxCity.Text) && !string.IsNullOrEmpty(comboBoxCountryContactList.Text);
        }


    }
}

