namespace FoodDeliverySYS
{
    partial class fmUpdateCustomers
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
            this.updateCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.customerID = new System.Windows.Forms.Label();
            this.btnCusIDSearch = new System.Windows.Forms.Button();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.eirCode_label = new System.Windows.Forms.Label();
            this.County_label = new System.Windows.Forms.Label();
            this.Town_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.email_labe = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Email = new System.Windows.Forms.Label();
            this.btnEmailSearch = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.updateCustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateCustomersGroupBox
            // 
            this.updateCustomersGroupBox.Controls.Add(this.btnEmailSearch);
            this.updateCustomersGroupBox.Controls.Add(this.txtEmail);
            this.updateCustomersGroupBox.Controls.Add(this.Email);
            this.updateCustomersGroupBox.Controls.Add(this.txtCusID);
            this.updateCustomersGroupBox.Controls.Add(this.customerID);
            this.updateCustomersGroupBox.Controls.Add(this.btnCusIDSearch);
            this.updateCustomersGroupBox.Controls.Add(this.cboCounty);
            this.updateCustomersGroupBox.Controls.Add(this.btnCancel);
            this.updateCustomersGroupBox.Controls.Add(this.btnUpdate);
            this.updateCustomersGroupBox.Controls.Add(this.txtEircode);
            this.updateCustomersGroupBox.Controls.Add(this.txtTown);
            this.updateCustomersGroupBox.Controls.Add(this.txtAddress);
            this.updateCustomersGroupBox.Controls.Add(this.txtPhoneNo);
            this.updateCustomersGroupBox.Controls.Add(this.emailTextBox);
            this.updateCustomersGroupBox.Controls.Add(this.txtLastName);
            this.updateCustomersGroupBox.Controls.Add(this.txtFirstName);
            this.updateCustomersGroupBox.Controls.Add(this.eirCode_label);
            this.updateCustomersGroupBox.Controls.Add(this.County_label);
            this.updateCustomersGroupBox.Controls.Add(this.Town_label);
            this.updateCustomersGroupBox.Controls.Add(this.address_label);
            this.updateCustomersGroupBox.Controls.Add(this.phoneNumber_label);
            this.updateCustomersGroupBox.Controls.Add(this.lastNamelabel);
            this.updateCustomersGroupBox.Controls.Add(this.email_labe);
            this.updateCustomersGroupBox.Controls.Add(this.firstNamelabel);
            this.updateCustomersGroupBox.Location = new System.Drawing.Point(47, 12);
            this.updateCustomersGroupBox.Name = "updateCustomersGroupBox";
            this.updateCustomersGroupBox.Size = new System.Drawing.Size(726, 618);
            this.updateCustomersGroupBox.TabIndex = 1;
            this.updateCustomersGroupBox.TabStop = false;
            this.updateCustomersGroupBox.Tag = "";
            this.updateCustomersGroupBox.Text = "updateCustomers";
            this.updateCustomersGroupBox.Enter += new System.EventHandler(this.updateCustomersGroupBox_Enter);
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(226, 74);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(337, 26);
            this.txtCusID.TabIndex = 21;
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(49, 76);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(148, 25);
            this.customerID.TabIndex = 20;
            this.customerID.Text = "Customer ID:";
            // 
            // btnCusIDSearch
            // 
            this.btnCusIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusIDSearch.Location = new System.Drawing.Point(598, 74);
            this.btnCusIDSearch.Name = "btnCusIDSearch";
            this.btnCusIDSearch.Size = new System.Drawing.Size(88, 26);
            this.btnCusIDSearch.TabIndex = 19;
            this.btnCusIDSearch.Text = "Search";
            this.btnCusIDSearch.UseVisualStyleBackColor = true;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "KERRY"});
            this.cboCounty.Location = new System.Drawing.Point(564, 353);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(144, 21);
            this.cboCounty.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(439, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 53);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(149, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 53);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(564, 416);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(90, 20);
            this.txtEircode.TabIndex = 15;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(218, 427);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(144, 20);
            this.txtTown.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(218, 353);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(144, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(564, 284);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(144, 20);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(218, 282);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(144, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(564, 215);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(218, 214);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // eirCode_label
            // 
            this.eirCode_label.AutoSize = true;
            this.eirCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eirCode_label.Location = new System.Drawing.Point(462, 411);
            this.eirCode_label.Name = "eirCode_label";
            this.eirCode_label.Size = new System.Drawing.Size(96, 25);
            this.eirCode_label.TabIndex = 7;
            this.eirCode_label.Text = "EirCode";
            // 
            // County_label
            // 
            this.County_label.AutoSize = true;
            this.County_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.County_label.Location = new System.Drawing.Point(472, 349);
            this.County_label.Name = "County_label";
            this.County_label.Size = new System.Drawing.Size(86, 25);
            this.County_label.TabIndex = 6;
            this.County_label.Text = "County";
            // 
            // Town_label
            // 
            this.Town_label.AutoSize = true;
            this.Town_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town_label.Location = new System.Drawing.Point(144, 421);
            this.Town_label.Name = "Town_label";
            this.Town_label.Size = new System.Drawing.Size(68, 25);
            this.Town_label.TabIndex = 5;
            this.Town_label.Text = "Town";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(114, 348);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(98, 25);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.Location = new System.Drawing.Point(391, 279);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(167, 25);
            this.phoneNumber_label.TabIndex = 3;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.Location = new System.Drawing.Point(434, 208);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(124, 25);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "Last Name";
            // 
            // email_labe
            // 
            this.email_labe.AutoSize = true;
            this.email_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_labe.Location = new System.Drawing.Point(49, 277);
            this.email_labe.Name = "email_labe";
            this.email_labe.Size = new System.Drawing.Size(163, 25);
            this.email_labe.TabIndex = 1;
            this.email_labe.Text = "Email Address";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.Location = new System.Drawing.Point(86, 210);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(126, 25);
            this.firstNamelabel.TabIndex = 0;
            this.firstNamelabel.Text = "First Name";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(55, 134);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(77, 25);
            this.Email.TabIndex = 22;
            this.Email.Text = "Email:";
            // 
            // btnEmailSearch
            // 
            this.btnEmailSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailSearch.Location = new System.Drawing.Point(598, 133);
            this.btnEmailSearch.Name = "btnEmailSearch";
            this.btnEmailSearch.Size = new System.Drawing.Size(88, 26);
            this.btnEmailSearch.TabIndex = 24;
            this.btnEmailSearch.Text = "Search";
            this.btnEmailSearch.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(226, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // fmUpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 642);
            this.Controls.Add(this.updateCustomersGroupBox);
            this.Name = "fmUpdateCustomers";
            this.Text = "fmUpdateCustomers";
            this.updateCustomersGroupBox.ResumeLayout(false);
            this.updateCustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox updateCustomersGroupBox;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label eirCode_label;
        private System.Windows.Forms.Label County_label;
        private System.Windows.Forms.Label Town_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label email_labe;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Button btnCusIDSearch;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnEmailSearch;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Email;
    }
}