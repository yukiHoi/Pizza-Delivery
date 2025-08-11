namespace FoodDeliverySYS
{
    partial class fmCustomers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.email_labe = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.Town_label = new System.Windows.Forms.Label();
            this.County_label = new System.Windows.Forms.Label();
            this.eirCode_label = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.addCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.addCustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.Location = new System.Drawing.Point(25, 62);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(126, 25);
            this.firstNamelabel.TabIndex = 0;
            this.firstNamelabel.Text = "First Name";
            // 
            // email_labe
            // 
            this.email_labe.AutoSize = true;
            this.email_labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_labe.Location = new System.Drawing.Point(25, 160);
            this.email_labe.Name = "email_labe";
            this.email_labe.Size = new System.Drawing.Size(163, 25);
            this.email_labe.TabIndex = 1;
            this.email_labe.Text = "Email Address";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.Location = new System.Drawing.Point(369, 62);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(124, 25);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "Last Name";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.Location = new System.Drawing.Point(369, 160);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(167, 25);
            this.phoneNumber_label.TabIndex = 3;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(25, 255);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(98, 25);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // Town_label
            // 
            this.Town_label.AutoSize = true;
            this.Town_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town_label.Location = new System.Drawing.Point(25, 353);
            this.Town_label.Name = "Town_label";
            this.Town_label.Size = new System.Drawing.Size(68, 25);
            this.Town_label.TabIndex = 5;
            this.Town_label.Text = "Town";
            this.Town_label.Click += new System.EventHandler(this.Town_label_Click);
            // 
            // County_label
            // 
            this.County_label.AutoSize = true;
            this.County_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.County_label.Location = new System.Drawing.Point(369, 255);
            this.County_label.Name = "County_label";
            this.County_label.Size = new System.Drawing.Size(86, 25);
            this.County_label.TabIndex = 6;
            this.County_label.Text = "County";
            // 
            // eirCode_label
            // 
            this.eirCode_label.AutoSize = true;
            this.eirCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eirCode_label.Location = new System.Drawing.Point(369, 353);
            this.eirCode_label.Name = "eirCode_label";
            this.eirCode_label.Size = new System.Drawing.Size(96, 25);
            this.eirCode_label.TabIndex = 7;
            this.eirCode_label.Text = "EirCode";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFirstName.Location = new System.Drawing.Point(167, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(499, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(542, 165);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(144, 20);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 261);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(144, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(99, 359);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(144, 20);
            this.txtTown.TabIndex = 14;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(471, 358);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(90, 20);
            this.txtEircode.TabIndex = 15;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(139, 445);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(172, 53);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(374, 445);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 53);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "KERRY"});
            this.cboCounty.Location = new System.Drawing.Point(461, 260);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(174, 21);
            this.cboCounty.TabIndex = 18;
            // 
            // addCustomersGroupBox
            // 
            this.addCustomersGroupBox.Controls.Add(this.cboCounty);
            this.addCustomersGroupBox.Controls.Add(this.btnReset);
            this.addCustomersGroupBox.Controls.Add(this.btnConfirm);
            this.addCustomersGroupBox.Controls.Add(this.txtEircode);
            this.addCustomersGroupBox.Controls.Add(this.txtTown);
            this.addCustomersGroupBox.Controls.Add(this.txtAddress);
            this.addCustomersGroupBox.Controls.Add(this.txtPhoneNo);
            this.addCustomersGroupBox.Controls.Add(this.txtEmail);
            this.addCustomersGroupBox.Controls.Add(this.txtLastName);
            this.addCustomersGroupBox.Controls.Add(this.txtFirstName);
            this.addCustomersGroupBox.Controls.Add(this.eirCode_label);
            this.addCustomersGroupBox.Controls.Add(this.County_label);
            this.addCustomersGroupBox.Controls.Add(this.Town_label);
            this.addCustomersGroupBox.Controls.Add(this.address_label);
            this.addCustomersGroupBox.Controls.Add(this.phoneNumber_label);
            this.addCustomersGroupBox.Controls.Add(this.lastNamelabel);
            this.addCustomersGroupBox.Controls.Add(this.email_labe);
            this.addCustomersGroupBox.Controls.Add(this.firstNamelabel);
            this.addCustomersGroupBox.Location = new System.Drawing.Point(47, 37);
            this.addCustomersGroupBox.Name = "addCustomersGroupBox";
            this.addCustomersGroupBox.Size = new System.Drawing.Size(721, 517);
            this.addCustomersGroupBox.TabIndex = 0;
            this.addCustomersGroupBox.TabStop = false;
            this.addCustomersGroupBox.Tag = "";
            this.addCustomersGroupBox.Text = "addNewCustomers";
            // 
            // fmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 643);
            this.Controls.Add(this.addCustomersGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmCustomers";
            this.Text = "Food Delivery -[Register New Customers]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addCustomersGroupBox.ResumeLayout(false);
            this.addCustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.Label email_labe;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label Town_label;
        private System.Windows.Forms.Label County_label;
        private System.Windows.Forms.Label eirCode_label;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.GroupBox addCustomersGroupBox;
    }
}