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
            btnAddMainForm = new Button();
            btnEditMainForm = new Button();
            btnDeleteMainForm = new Button();
            lblIDMainForm = new Label();
            lblNameMainForm = new Label();
            lblOfficePhoneMainForm = new Label();
            lblOfficeEmailContactForm = new Label();
            lblContactDetailsMainForm = new Label();
            listViewCompleteContact = new ListView();
            SuspendLayout();
            // 
            // listBoxPartialData
            // 
            listBoxPartialData.FormattingEnabled = true;
            listBoxPartialData.Location = new Point(1, 49);
            listBoxPartialData.Margin = new Padding(2, 3, 2, 3);
            listBoxPartialData.Name = "listBoxPartialData";
            listBoxPartialData.Size = new Size(642, 484);
            listBoxPartialData.TabIndex = 0;
            listBoxPartialData.SelectedIndexChanged += listBoxPartialData_SelectedIndexChanged;
            // 
            // btnAddMainForm
            // 
            btnAddMainForm.Location = new Point(11, 554);
            btnAddMainForm.Margin = new Padding(2, 3, 2, 3);
            btnAddMainForm.Name = "btnAddMainForm";
            btnAddMainForm.Size = new Size(183, 27);
            btnAddMainForm.TabIndex = 2;
            btnAddMainForm.Text = "Add";
            btnAddMainForm.UseVisualStyleBackColor = true;
            // 
            // btnEditMainForm
            // 
            btnEditMainForm.Location = new Point(223, 554);
            btnEditMainForm.Margin = new Padding(2, 3, 2, 3);
            btnEditMainForm.Name = "btnEditMainForm";
            btnEditMainForm.Size = new Size(178, 27);
            btnEditMainForm.TabIndex = 3;
            btnEditMainForm.Text = "Edit";
            btnEditMainForm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMainForm
            // 
            btnDeleteMainForm.Location = new Point(428, 554);
            btnDeleteMainForm.Margin = new Padding(2, 3, 2, 3);
            btnDeleteMainForm.Name = "btnDeleteMainForm";
            btnDeleteMainForm.Size = new Size(202, 27);
            btnDeleteMainForm.TabIndex = 4;
            btnDeleteMainForm.Text = "Delete";
            btnDeleteMainForm.UseVisualStyleBackColor = true;
            // 
            // lblIDMainForm
            // 
            lblIDMainForm.AutoSize = true;
            lblIDMainForm.Location = new Point(25, 13);
            lblIDMainForm.Margin = new Padding(2, 0, 2, 0);
            lblIDMainForm.Name = "lblIDMainForm";
            lblIDMainForm.Size = new Size(22, 20);
            lblIDMainForm.TabIndex = 5;
            lblIDMainForm.Text = "Id";
            // 
            // lblNameMainForm
            // 
            lblNameMainForm.AutoSize = true;
            lblNameMainForm.Location = new Point(119, 13);
            lblNameMainForm.Margin = new Padding(2, 0, 2, 0);
            lblNameMainForm.Name = "lblNameMainForm";
            lblNameMainForm.Size = new Size(194, 20);
            lblNameMainForm.TabIndex = 6;
            lblNameMainForm.Text = "Name (Surname, first name)";
            // 
            // lblOfficePhoneMainForm
            // 
            lblOfficePhoneMainForm.AutoSize = true;
            lblOfficePhoneMainForm.Location = new Point(347, 13);
            lblOfficePhoneMainForm.Margin = new Padding(2, 0, 2, 0);
            lblOfficePhoneMainForm.Name = "lblOfficePhoneMainForm";
            lblOfficePhoneMainForm.Size = new Size(95, 20);
            lblOfficePhoneMainForm.TabIndex = 7;
            lblOfficePhoneMainForm.Text = "Office phone";
            // 
            // lblOfficeEmailContactForm
            // 
            lblOfficeEmailContactForm.AutoSize = true;
            lblOfficeEmailContactForm.Location = new Point(507, 13);
            lblOfficeEmailContactForm.Margin = new Padding(2, 0, 2, 0);
            lblOfficeEmailContactForm.Name = "lblOfficeEmailContactForm";
            lblOfficeEmailContactForm.Size = new Size(90, 20);
            lblOfficeEmailContactForm.TabIndex = 8;
            lblOfficeEmailContactForm.Text = "Office email";
            // 
            // lblContactDetailsMainForm
            // 
            lblContactDetailsMainForm.AutoSize = true;
            lblContactDetailsMainForm.Location = new Point(841, 13);
            lblContactDetailsMainForm.Margin = new Padding(2, 0, 2, 0);
            lblContactDetailsMainForm.Name = "lblContactDetailsMainForm";
            lblContactDetailsMainForm.Size = new Size(108, 20);
            lblContactDetailsMainForm.TabIndex = 9;
            lblContactDetailsMainForm.Text = "Contact details";
            // 
            // listViewCompleteContact
            // 
            listViewCompleteContact.AllowColumnReorder = true;
            listViewCompleteContact.Location = new Point(647, 49);
            listViewCompleteContact.Margin = new Padding(2, 3, 2, 3);
            listViewCompleteContact.Name = "listViewCompleteContact";
            listViewCompleteContact.Size = new Size(908, 532);
            listViewCompleteContact.TabIndex = 10;
            listViewCompleteContact.UseCompatibleStateImageBehavior = false;
            listViewCompleteContact.View = View.Details;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 680);
            Controls.Add(listViewCompleteContact);
            Controls.Add(lblContactDetailsMainForm);
            Controls.Add(lblOfficeEmailContactForm);
            Controls.Add(lblOfficePhoneMainForm);
            Controls.Add(lblNameMainForm);
            Controls.Add(lblIDMainForm);
            Controls.Add(btnDeleteMainForm);
            Controls.Add(btnEditMainForm);
            Controls.Add(btnAddMainForm);
            Controls.Add(listBoxPartialData);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Customer registry by Ann-Sofie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPartialData;
        private Button btnAddMainForm;
        private Button btnEditMainForm;
        private Button btnDeleteMainForm;
        private Label lblIDMainForm;
        private Label lblNameMainForm;
        private Label lblOfficePhoneMainForm;
        private Label lblOfficeEmailContactForm;
        private Label lblContactDetailsMainForm;
        private ListView listViewCompleteContact;
    }
}
