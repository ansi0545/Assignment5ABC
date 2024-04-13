namespace Assignment5ABC
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxNameContactForm = new GroupBox();
            lblLastNameContactForm = new Label();
            lblFirstNameContactForm = new Label();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            grpBoxEmailAndPhoneContactForm = new GroupBox();
            lblEmailPrivateContactForm = new Label();
            lblEmailBusiness = new Label();
            txtBoxEmailBusinessContactForm = new TextBox();
            txtBoxEmailPrivateContactForm = new TextBox();
            lblCellPhoneContactForm = new Label();
            lblHomePhoneContactForm = new Label();
            txtBoxCellPhoneContactForm = new TextBox();
            txtBoxHomePhoneContactForm = new TextBox();
            grpBoxAdressContactForm = new GroupBox();
            comboBoxCountryContactList = new ComboBox();
            lblCountryContactForm = new Label();
            lblZipCodeContactForm = new Label();
            textBox1 = new TextBox();
            lblCityContactForm = new Label();
            lblStreetContactForm = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnOKContactForm = new Button();
            btnCancelContactForm = new Button();
            groupBoxNameContactForm.SuspendLayout();
            grpBoxEmailAndPhoneContactForm.SuspendLayout();
            grpBoxAdressContactForm.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNameContactForm
            // 
            groupBoxNameContactForm.Controls.Add(lblLastNameContactForm);
            groupBoxNameContactForm.Controls.Add(lblFirstNameContactForm);
            groupBoxNameContactForm.Controls.Add(txtBoxLastName);
            groupBoxNameContactForm.Controls.Add(txtBoxFirstName);
            groupBoxNameContactForm.Location = new Point(12, 17);
            groupBoxNameContactForm.Name = "groupBoxNameContactForm";
            groupBoxNameContactForm.Size = new Size(776, 157);
            groupBoxNameContactForm.TabIndex = 0;
            groupBoxNameContactForm.TabStop = false;
            groupBoxNameContactForm.Text = "Name";
            // 
            // lblLastNameContactForm
            // 
            lblLastNameContactForm.AutoSize = true;
            lblLastNameContactForm.Location = new Point(164, 83);
            lblLastNameContactForm.Name = "lblLastNameContactForm";
            lblLastNameContactForm.Size = new Size(92, 25);
            lblLastNameContactForm.TabIndex = 3;
            lblLastNameContactForm.Text = "Last name";
            // 
            // lblFirstNameContactForm
            // 
            lblFirstNameContactForm.AutoSize = true;
            lblFirstNameContactForm.Location = new Point(164, 36);
            lblFirstNameContactForm.Name = "lblFirstNameContactForm";
            lblFirstNameContactForm.Size = new Size(94, 25);
            lblFirstNameContactForm.TabIndex = 2;
            lblFirstNameContactForm.Text = "First name";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(366, 77);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(385, 31);
            txtBoxLastName.TabIndex = 1;
            txtBoxLastName.TextChanged += txtBoxLastName_TextChanged;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(366, 30);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(385, 31);
            txtBoxFirstName.TabIndex = 0;
            txtBoxFirstName.TextChanged += txtBoxFirstName_TextChanged;
            // 
            // grpBoxEmailAndPhoneContactForm
            // 
            grpBoxEmailAndPhoneContactForm.Controls.Add(lblEmailPrivateContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(lblEmailBusiness);
            grpBoxEmailAndPhoneContactForm.Controls.Add(txtBoxEmailBusinessContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(txtBoxEmailPrivateContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(lblCellPhoneContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(lblHomePhoneContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(txtBoxCellPhoneContactForm);
            grpBoxEmailAndPhoneContactForm.Controls.Add(txtBoxHomePhoneContactForm);
            grpBoxEmailAndPhoneContactForm.Location = new Point(12, 180);
            grpBoxEmailAndPhoneContactForm.Name = "grpBoxEmailAndPhoneContactForm";
            grpBoxEmailAndPhoneContactForm.Size = new Size(776, 222);
            grpBoxEmailAndPhoneContactForm.TabIndex = 1;
            grpBoxEmailAndPhoneContactForm.TabStop = false;
            grpBoxEmailAndPhoneContactForm.Text = "Email and phone";
            // 
            // lblEmailPrivateContactForm
            // 
            lblEmailPrivateContactForm.AutoSize = true;
            lblEmailPrivateContactForm.Location = new Point(164, 174);
            lblEmailPrivateContactForm.Name = "lblEmailPrivateContactForm";
            lblEmailPrivateContactForm.Size = new Size(117, 25);
            lblEmailPrivateContactForm.TabIndex = 7;
            lblEmailPrivateContactForm.Text = "Email, private";
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.Location = new Point(164, 130);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(131, 25);
            lblEmailBusiness.TabIndex = 6;
            lblEmailBusiness.Text = "Email, business";
            // 
            // txtBoxEmailBusinessContactForm
            // 
            txtBoxEmailBusinessContactForm.Location = new Point(366, 124);
            txtBoxEmailBusinessContactForm.Name = "txtBoxEmailBusinessContactForm";
            txtBoxEmailBusinessContactForm.Size = new Size(385, 31);
            txtBoxEmailBusinessContactForm.TabIndex = 5;
            txtBoxEmailBusinessContactForm.TextChanged += txtBoxEmailBusinessContactForm_TextChanged;
            // 
            // txtBoxEmailPrivateContactForm
            // 
            txtBoxEmailPrivateContactForm.Location = new Point(366, 168);
            txtBoxEmailPrivateContactForm.Name = "txtBoxEmailPrivateContactForm";
            txtBoxEmailPrivateContactForm.Size = new Size(385, 31);
            txtBoxEmailPrivateContactForm.TabIndex = 4;
            txtBoxEmailPrivateContactForm.TextChanged += txtBoxEmailPrivateContactForm_TextChanged;
            // 
            // lblCellPhoneContactForm
            // 
            lblCellPhoneContactForm.AutoSize = true;
            lblCellPhoneContactForm.Location = new Point(164, 83);
            lblCellPhoneContactForm.Name = "lblCellPhoneContactForm";
            lblCellPhoneContactForm.Size = new Size(96, 25);
            lblCellPhoneContactForm.TabIndex = 3;
            lblCellPhoneContactForm.Text = "Cell phone";
            // 
            // lblHomePhoneContactForm
            // 
            lblHomePhoneContactForm.AutoSize = true;
            lblHomePhoneContactForm.Location = new Point(164, 36);
            lblHomePhoneContactForm.Name = "lblHomePhoneContactForm";
            lblHomePhoneContactForm.Size = new Size(117, 25);
            lblHomePhoneContactForm.TabIndex = 2;
            lblHomePhoneContactForm.Text = "Home phone";
            // 
            // txtBoxCellPhoneContactForm
            // 
            txtBoxCellPhoneContactForm.Location = new Point(366, 77);
            txtBoxCellPhoneContactForm.Name = "txtBoxCellPhoneContactForm";
            txtBoxCellPhoneContactForm.Size = new Size(385, 31);
            txtBoxCellPhoneContactForm.TabIndex = 1;
            txtBoxCellPhoneContactForm.TextChanged += txtBoxCellPhoneContactForm_TextChanged;
            // 
            // txtBoxHomePhoneContactForm
            // 
            txtBoxHomePhoneContactForm.Location = new Point(366, 30);
            txtBoxHomePhoneContactForm.Name = "txtBoxHomePhoneContactForm";
            txtBoxHomePhoneContactForm.Size = new Size(385, 31);
            txtBoxHomePhoneContactForm.TabIndex = 0;
            txtBoxHomePhoneContactForm.TextChanged += txtBoxHomePhoneContactForm_TextChanged;
            // 
            // grpBoxAdressContactForm
            // 
            grpBoxAdressContactForm.Controls.Add(comboBoxCountryContactList);
            grpBoxAdressContactForm.Controls.Add(lblCountryContactForm);
            grpBoxAdressContactForm.Controls.Add(lblZipCodeContactForm);
            grpBoxAdressContactForm.Controls.Add(textBox1);
            grpBoxAdressContactForm.Controls.Add(lblCityContactForm);
            grpBoxAdressContactForm.Controls.Add(lblStreetContactForm);
            grpBoxAdressContactForm.Controls.Add(textBox3);
            grpBoxAdressContactForm.Controls.Add(textBox4);
            grpBoxAdressContactForm.Location = new Point(12, 408);
            grpBoxAdressContactForm.Name = "grpBoxAdressContactForm";
            grpBoxAdressContactForm.Size = new Size(776, 236);
            grpBoxAdressContactForm.TabIndex = 2;
            grpBoxAdressContactForm.TabStop = false;
            grpBoxAdressContactForm.Text = "Address";
            // 
            // comboBoxCountryContactList
            // 
            comboBoxCountryContactList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountryContactList.FormattingEnabled = true;
            comboBoxCountryContactList.Location = new Point(366, 166);
            comboBoxCountryContactList.Name = "comboBoxCountryContactList";
            comboBoxCountryContactList.Size = new Size(385, 33);
            comboBoxCountryContactList.TabIndex = 8;
            comboBoxCountryContactList.SelectedIndexChanged += comboBoxCountryContactList_SelectedIndexChanged;
            // 
            // lblCountryContactForm
            // 
            lblCountryContactForm.AutoSize = true;
            lblCountryContactForm.Location = new Point(164, 174);
            lblCountryContactForm.Name = "lblCountryContactForm";
            lblCountryContactForm.Size = new Size(75, 25);
            lblCountryContactForm.TabIndex = 7;
            lblCountryContactForm.Text = "Country";
            // 
            // lblZipCodeContactForm
            // 
            lblZipCodeContactForm.AutoSize = true;
            lblZipCodeContactForm.Location = new Point(164, 130);
            lblZipCodeContactForm.Name = "lblZipCodeContactForm";
            lblZipCodeContactForm.Size = new Size(81, 25);
            lblZipCodeContactForm.TabIndex = 6;
            lblZipCodeContactForm.Text = "Zip code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(366, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblCityContactForm
            // 
            lblCityContactForm.AutoSize = true;
            lblCityContactForm.Location = new Point(164, 83);
            lblCityContactForm.Name = "lblCityContactForm";
            lblCityContactForm.Size = new Size(42, 25);
            lblCityContactForm.TabIndex = 3;
            lblCityContactForm.Text = "City";
            // 
            // lblStreetContactForm
            // 
            lblStreetContactForm.AutoSize = true;
            lblStreetContactForm.Location = new Point(164, 36);
            lblStreetContactForm.Name = "lblStreetContactForm";
            lblStreetContactForm.Size = new Size(57, 25);
            lblStreetContactForm.TabIndex = 2;
            lblStreetContactForm.Text = "Street";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(366, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(385, 31);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(366, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(385, 31);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // btnOKContactForm
            // 
            btnOKContactForm.Location = new Point(179, 677);
            btnOKContactForm.Name = "btnOKContactForm";
            btnOKContactForm.Size = new Size(112, 34);
            btnOKContactForm.TabIndex = 3;
            btnOKContactForm.Text = "OK";
            btnOKContactForm.UseVisualStyleBackColor = true;
            btnOKContactForm.Click += btnOKContactForm_Click;
            // 
            // btnCancelContactForm
            // 
            btnCancelContactForm.Location = new Point(470, 677);
            btnCancelContactForm.Name = "btnCancelContactForm";
            btnCancelContactForm.Size = new Size(112, 34);
            btnCancelContactForm.TabIndex = 4;
            btnCancelContactForm.Text = "Cancel";
            btnCancelContactForm.UseVisualStyleBackColor = true;
            btnCancelContactForm.Click += btnCancelContactForm_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 742);
            Controls.Add(btnCancelContactForm);
            Controls.Add(btnOKContactForm);
            Controls.Add(grpBoxAdressContactForm);
            Controls.Add(grpBoxEmailAndPhoneContactForm);
            Controls.Add(groupBoxNameContactForm);
            Name = "ContactForm";
            Text = "ContactForm";
            groupBoxNameContactForm.ResumeLayout(false);
            groupBoxNameContactForm.PerformLayout();
            grpBoxEmailAndPhoneContactForm.ResumeLayout(false);
            grpBoxEmailAndPhoneContactForm.PerformLayout();
            grpBoxAdressContactForm.ResumeLayout(false);
            grpBoxAdressContactForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNameContactForm;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label lblLastNameContactForm;
        private Label lblFirstNameContactForm;
        private GroupBox grpBoxEmailAndPhoneContactForm;
        private TextBox txtBoxEmailBusinessContactForm;
        private TextBox txtBoxEmailPrivateContactForm;
        private Label lblCellPhoneContactForm;
        private Label lblHomePhoneContactForm;
        private TextBox txtBoxCellPhoneContactForm;
        private TextBox txtBoxHomePhoneContactForm;
        private Label lblEmailPrivateContactForm;
        private Label lblEmailBusiness;
        private GroupBox grpBoxAdressContactForm;
        private Label lblCountryContactForm;
        private Label lblZipCodeContactForm;
        private TextBox textBox1;
        private Label lblCityContactForm;
        private Label lblStreetContactForm;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBoxCountryContactList;
        private Button btnOKContactForm;
        private Button btnCancelContactForm;
    }
}