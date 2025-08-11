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
            this.customerID = new System.Windows.Forms.Label();
            this.comboBoxCounty = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PhoneNumTextBox4 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.eirCode_label = new System.Windows.Forms.Label();
            this.County_label = new System.Windows.Forms.Label();
            this.Town_label = new System.Windows.Forms.Label();
            this.address2_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.address_labe = new System.Windows.Forms.Label();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.updateCustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateCustomersGroupBox
            // 
            this.updateCustomersGroupBox.Controls.Add(this.comboBoxCounty);
            this.updateCustomersGroupBox.Controls.Add(this.CancelButton);
            this.updateCustomersGroupBox.Controls.Add(this.updateButton);
            this.updateCustomersGroupBox.Controls.Add(this.textBox8);
            this.updateCustomersGroupBox.Controls.Add(this.textBox7);
            this.updateCustomersGroupBox.Controls.Add(this.textBox5);
            this.updateCustomersGroupBox.Controls.Add(this.PhoneNumTextBox4);
            this.updateCustomersGroupBox.Controls.Add(this.emailTextBox);
            this.updateCustomersGroupBox.Controls.Add(this.txtLName);
            this.updateCustomersGroupBox.Controls.Add(this.txtFName);
            this.updateCustomersGroupBox.Controls.Add(this.eirCode_label);
            this.updateCustomersGroupBox.Controls.Add(this.County_label);
            this.updateCustomersGroupBox.Controls.Add(this.Town_label);
            this.updateCustomersGroupBox.Controls.Add(this.address2_label);
            this.updateCustomersGroupBox.Controls.Add(this.phoneNumber_label);
            this.updateCustomersGroupBox.Controls.Add(this.lastNamelabel);
            this.updateCustomersGroupBox.Controls.Add(this.address_labe);
            this.updateCustomersGroupBox.Controls.Add(this.firstNamelabel);
            this.updateCustomersGroupBox.Location = new System.Drawing.Point(137, 132);
            this.updateCustomersGroupBox.Name = "updateCustomersGroupBox";
            this.updateCustomersGroupBox.Size = new System.Drawing.Size(737, 437);
            this.updateCustomersGroupBox.TabIndex = 1;
            this.updateCustomersGroupBox.TabStop = false;
            this.updateCustomersGroupBox.Tag = "";
            this.updateCustomersGroupBox.Text = "updateCustomerDetail";
            this.updateCustomersGroupBox.Enter += new System.EventHandler(this.updateCustomersGroupBox_Enter);
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(226, 67);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(141, 25);
            this.customerID.TabIndex = 20;
            this.customerID.Text = "Customer ID";
            // 
            // comboBoxCounty
            // 
            this.comboBoxCounty.FormattingEnabled = true;
            this.comboBoxCounty.Items.AddRange(new object[] {
            "KERRY"});
            this.comboBoxCounty.Location = new System.Drawing.Point(554, 200);
            this.comboBoxCounty.Name = "comboBoxCounty";
            this.comboBoxCounty.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCounty.TabIndex = 18;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(444, 343);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(172, 53);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(112, 343);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(172, 53);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(554, 279);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(90, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(195, 273);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(195, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 12;
            // 
            // PhoneNumTextBox4
            // 
            this.PhoneNumTextBox4.Location = new System.Drawing.Point(554, 125);
            this.PhoneNumTextBox4.Name = "PhoneNumTextBox4";
            this.PhoneNumTextBox4.Size = new System.Drawing.Size(144, 20);
            this.PhoneNumTextBox4.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(195, 120);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(144, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(554, 38);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(144, 20);
            this.txtLName.TabIndex = 9;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(195, 44);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(144, 20);
            this.txtFName.TabIndex = 8;
            // 
            // eirCode_label
            // 
            this.eirCode_label.AutoSize = true;
            this.eirCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eirCode_label.Location = new System.Drawing.Point(439, 273);
            this.eirCode_label.Name = "eirCode_label";
            this.eirCode_label.Size = new System.Drawing.Size(96, 25);
            this.eirCode_label.TabIndex = 7;
            this.eirCode_label.Text = "EirCode";
            // 
            // County_label
            // 
            this.County_label.AutoSize = true;
            this.County_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.County_label.Location = new System.Drawing.Point(439, 196);
            this.County_label.Name = "County_label";
            this.County_label.Size = new System.Drawing.Size(86, 25);
            this.County_label.TabIndex = 6;
            this.County_label.Text = "County";
            // 
            // Town_label
            // 
            this.Town_label.AutoSize = true;
            this.Town_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town_label.Location = new System.Drawing.Point(84, 267);
            this.Town_label.Name = "Town_label";
            this.Town_label.Size = new System.Drawing.Size(68, 25);
            this.Town_label.TabIndex = 5;
            this.Town_label.Text = "Town";
            // 
            // address2_label
            // 
            this.address2_label.AutoSize = true;
            this.address2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2_label.Location = new System.Drawing.Point(34, 196);
            this.address2_label.Name = "address2_label";
            this.address2_label.Size = new System.Drawing.Size(118, 25);
            this.address2_label.TabIndex = 4;
            this.address2_label.Text = "Address 2";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.Location = new System.Drawing.Point(370, 120);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(167, 25);
            this.phoneNumber_label.TabIndex = 3;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.Location = new System.Drawing.Point(413, 33);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(124, 25);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "Last Name";
            // 
            // address_labe
            // 
            this.address_labe.AutoSize = true;
            this.address_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_labe.Location = new System.Drawing.Point(34, 115);
            this.address_labe.Name = "address_labe";
            this.address_labe.Size = new System.Drawing.Size(118, 25);
            this.address_labe.TabIndex = 1;
            this.address_labe.Text = "Address 1";
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.Location = new System.Drawing.Point(26, 38);
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
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Items.AddRange(new object[] {
            "00001",
            "00002",
            "00003",
            "00004"});
            this.updateComboBox.Location = new System.Drawing.Point(404, 73);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(258, 21);
            this.updateComboBox.TabIndex = 25;
            // 
            // fmUpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 642);
            this.Controls.Add(this.updateComboBox);
            this.Controls.Add(this.updateCustomersGroupBox);
            this.Controls.Add(this.customerID);
            this.Name = "fmUpdateCustomers";
            this.Text = "fmUpdateCustomers";
            this.updateCustomersGroupBox.ResumeLayout(false);
            this.updateCustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox updateCustomersGroupBox;
        private System.Windows.Forms.ComboBox comboBoxCounty;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox PhoneNumTextBox4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label eirCode_label;
        private System.Windows.Forms.Label County_label;
        private System.Windows.Forms.Label Town_label;
        private System.Windows.Forms.Label address2_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label address_labe;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.Label customerID;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox updateComboBox;
    }
}