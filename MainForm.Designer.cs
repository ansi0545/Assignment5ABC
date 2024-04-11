namespace Assignment5ABC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPartialData = new ListBox();
            listBoxCompleteContact = new ListBox();
            btnAddMainForm = new Button();
            btnEditMainForm = new Button();
            btnDeleteMainForm = new Button();
            lblIDMainForm = new Label();
            lblNameMainForm = new Label();
            lblOfficePhoneMainForm = new Label();
            lblOfficeEmailContactForm = new Label();
            lblContactDetailsMainForm = new Label();
            SuspendLayout();
            // 
            // listBoxPartialData
            // 
            listBoxPartialData.FormattingEnabled = true;
            listBoxPartialData.ItemHeight = 25;
            listBoxPartialData.Location = new Point(2, 61);
            listBoxPartialData.Name = "listBoxPartialData";
            listBoxPartialData.Size = new Size(826, 604);
            listBoxPartialData.TabIndex = 0;
            listBoxPartialData.SelectedIndexChanged += this.listBoxPartialData_SelectedIndexChanged;
            // 
            // listBoxCompleteContact
            // 
            listBoxCompleteContact.BackColor = SystemColors.Control;
            listBoxCompleteContact.FormattingEnabled = true;
            listBoxCompleteContact.ItemHeight = 25;
            listBoxCompleteContact.Location = new Point(834, 61);
            listBoxCompleteContact.Name = "listBoxCompleteContact";
            listBoxCompleteContact.Size = new Size(558, 604);
            listBoxCompleteContact.TabIndex = 1;
            listBoxCompleteContact.SelectedIndexChanged += this.listBoxCompleteContact_SelectedIndexChanged;
            // 
            // btnAddMainForm
            // 
            btnAddMainForm.Location = new Point(32, 677);
            btnAddMainForm.Name = "btnAddMainForm";
            btnAddMainForm.Size = new Size(229, 34);
            btnAddMainForm.TabIndex = 2;
            btnAddMainForm.Text = "Add";
            btnAddMainForm.UseVisualStyleBackColor = true;
            // 
            // btnEditMainForm
            // 
            btnEditMainForm.Location = new Point(291, 677);
            btnEditMainForm.Name = "btnEditMainForm";
            btnEditMainForm.Size = new Size(223, 34);
            btnEditMainForm.TabIndex = 3;
            btnEditMainForm.Text = "Edit";
            btnEditMainForm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMainForm
            // 
            btnDeleteMainForm.Location = new Point(550, 677);
            btnDeleteMainForm.Name = "btnDeleteMainForm";
            btnDeleteMainForm.Size = new Size(253, 34);
            btnDeleteMainForm.TabIndex = 4;
            btnDeleteMainForm.Text = "Delete";
            btnDeleteMainForm.UseVisualStyleBackColor = true;
            // 
            // lblIDMainForm
            // 
            lblIDMainForm.AutoSize = true;
            lblIDMainForm.Location = new Point(32, 17);
            lblIDMainForm.Name = "lblIDMainForm";
            lblIDMainForm.Size = new Size(28, 25);
            lblIDMainForm.TabIndex = 5;
            lblIDMainForm.Text = "Id";
            // 
            // lblNameMainForm
            // 
            lblNameMainForm.AutoSize = true;
            lblNameMainForm.Location = new Point(168, 17);
            lblNameMainForm.Name = "lblNameMainForm";
            lblNameMainForm.Size = new Size(232, 25);
            lblNameMainForm.TabIndex = 6;
            lblNameMainForm.Text = "Name (Surname, first name ";
            // 
            // lblOfficePhoneMainForm
            // 
            lblOfficePhoneMainForm.AutoSize = true;
            lblOfficePhoneMainForm.Location = new Point(444, 17);
            lblOfficePhoneMainForm.Name = "lblOfficePhoneMainForm";
            lblOfficePhoneMainForm.Size = new Size(115, 25);
            lblOfficePhoneMainForm.TabIndex = 7;
            lblOfficePhoneMainForm.Text = "Office phone";
            // 
            // lblOfficeEmailContactForm
            // 
            lblOfficeEmailContactForm.AutoSize = true;
            lblOfficeEmailContactForm.Location = new Point(652, 17);
            lblOfficeEmailContactForm.Name = "lblOfficeEmailContactForm";
            lblOfficeEmailContactForm.Size = new Size(106, 25);
            lblOfficeEmailContactForm.TabIndex = 8;
            lblOfficeEmailContactForm.Text = "Office email";
            // 
            // lblContactDetailsMainForm
            // 
            lblContactDetailsMainForm.AutoSize = true;
            lblContactDetailsMainForm.Location = new Point(1051, 17);
            lblContactDetailsMainForm.Name = "lblContactDetailsMainForm";
            lblContactDetailsMainForm.Size = new Size(129, 25);
            lblContactDetailsMainForm.TabIndex = 9;
            lblContactDetailsMainForm.Text = "Contact details";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 723);
            Controls.Add(lblContactDetailsMainForm);
            Controls.Add(lblOfficeEmailContactForm);
            Controls.Add(lblOfficePhoneMainForm);
            Controls.Add(lblNameMainForm);
            Controls.Add(lblIDMainForm);
            Controls.Add(btnDeleteMainForm);
            Controls.Add(btnEditMainForm);
            Controls.Add(btnAddMainForm);
            Controls.Add(listBoxCompleteContact);
            Controls.Add(listBoxPartialData);
            Name = "MainForm";
            Text = "Customer registry by Ann-Sofie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPartialData;
        private ListBox listBoxCompleteContact;
        private Button btnAddMainForm;
        private Button btnEditMainForm;
        private Button btnDeleteMainForm;
        private Label lblIDMainForm;
        private Label lblNameMainForm;
        private Label lblOfficePhoneMainForm;
        private Label lblOfficeEmailContactForm;
        private Label lblContactDetailsMainForm;
    }
}
