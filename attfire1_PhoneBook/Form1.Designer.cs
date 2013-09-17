namespace attfire1_PhoneBook
{
    partial class Form1
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.submitData_btn = new System.Windows.Forms.Button();
            this.displayContactsListBox = new System.Windows.Forms.ListBox();
            this.retrieveContactsBtn = new System.Windows.Forms.Button();
            this.loadListItem = new System.Windows.Forms.Button();
            this.updateContact = new System.Windows.Forms.Button();
            this.deleteContact = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(27, 37);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(27, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(109, 30);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textBox.TabIndex = 2;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(109, 66);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textBox.TabIndex = 3;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(27, 95);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(78, 13);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Phone Number";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(109, 96);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber_textBox.TabIndex = 5;
            // 
            // submitData_btn
            // 
            this.submitData_btn.Location = new System.Drawing.Point(29, 122);
            this.submitData_btn.Name = "submitData_btn";
            this.submitData_btn.Size = new System.Drawing.Size(75, 23);
            this.submitData_btn.TabIndex = 6;
            this.submitData_btn.Text = "Add Contact";
            this.submitData_btn.UseVisualStyleBackColor = true;
            this.submitData_btn.Click += new System.EventHandler(this.submitData_btn_Click);
            // 
            // displayContactsListBox
            // 
            this.displayContactsListBox.FormattingEnabled = true;
            this.displayContactsListBox.Location = new System.Drawing.Point(30, 218);
            this.displayContactsListBox.Name = "displayContactsListBox";
            this.displayContactsListBox.Size = new System.Drawing.Size(262, 95);
            this.displayContactsListBox.TabIndex = 7;
            // 
            // retrieveContactsBtn
            // 
            this.retrieveContactsBtn.Location = new System.Drawing.Point(30, 189);
            this.retrieveContactsBtn.Name = "retrieveContactsBtn";
            this.retrieveContactsBtn.Size = new System.Drawing.Size(120, 23);
            this.retrieveContactsBtn.TabIndex = 8;
            this.retrieveContactsBtn.Text = "Retrieve Contacts";
            this.retrieveContactsBtn.UseVisualStyleBackColor = true;
            this.retrieveContactsBtn.Click += new System.EventHandler(this.retrieveContactsBtn_Click);
            // 
            // loadListItem
            // 
            this.loadListItem.Location = new System.Drawing.Point(156, 189);
            this.loadListItem.Name = "loadListItem";
            this.loadListItem.Size = new System.Drawing.Size(136, 23);
            this.loadListItem.TabIndex = 9;
            this.loadListItem.Text = "Load List Item into Fields";
            this.loadListItem.UseVisualStyleBackColor = true;
            this.loadListItem.Click += new System.EventHandler(this.loadListItem_Click);
            // 
            // updateContact
            // 
            this.updateContact.Location = new System.Drawing.Point(112, 122);
            this.updateContact.Name = "updateContact";
            this.updateContact.Size = new System.Drawing.Size(97, 23);
            this.updateContact.TabIndex = 10;
            this.updateContact.Text = "Update Contact";
            this.updateContact.UseVisualStyleBackColor = true;
            this.updateContact.Click += new System.EventHandler(this.updateContact_Click);
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(216, 122);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(86, 23);
            this.deleteContact.TabIndex = 11;
            this.deleteContact.Text = "Delete Contact";
            this.deleteContact.UseVisualStyleBackColor = true;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // clearFields
            // 
            this.clearFields.Location = new System.Drawing.Point(315, 13);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(75, 23);
            this.clearFields.TabIndex = 12;
            this.clearFields.Text = "Clear Fields";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.updateContact);
            this.Controls.Add(this.loadListItem);
            this.Controls.Add(this.retrieveContactsBtn);
            this.Controls.Add(this.displayContactsListBox);
            this.Controls.Add(this.submitData_btn);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "\"Simple\" Entity Framework C.R.U.D Exersize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Button submitData_btn;
        private System.Windows.Forms.ListBox displayContactsListBox;
        private System.Windows.Forms.Button retrieveContactsBtn;
        private System.Windows.Forms.Button loadListItem;
        private System.Windows.Forms.Button updateContact;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Button clearFields;
    }
}

