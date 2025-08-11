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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.email_labe = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.Town_label = new System.Windows.Forms.Label();
            this.County_label = new System.Windows.Forms.Label();
            this.eirCode_label = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.town = new System.Windows.Forms.TextBox();
            this.eirCode = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.comboBoxCounty = new System.Windows.Forms.ComboBox();
            this.addCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.addCustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.firstNamelabel.Location = new System.Drawing.Point(25, 63);
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
            this.lastNamelabel.Location = new System.Drawing.Point(385, 57);
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
            this.address_label.Location = new System.Drawing.Point(53, 254);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(98, 25);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Address";
            // 
            // Town_label
            // 
            this.Town_label.AutoSize = true;
            this.Town_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town_label.Location = new System.Drawing.Point(65, 352);
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
            this.County_label.Location = new System.Drawing.Point(407, 255);
            this.County_label.Name = "County_label";
            this.County_label.Size = new System.Drawing.Size(86, 25);
            this.County_label.TabIndex = 6;
            this.County_label.Text = "County";
            // 
            // eirCode_label
            // 
            this.eirCode_label.AutoSize = true;
            this.eirCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eirCode_label.Location = new System.Drawing.Point(397, 352);
            this.eirCode_label.Name = "eirCode_label";
            this.eirCode_label.Size = new System.Drawing.Size(96, 25);
            this.eirCode_label.TabIndex = 7;
            this.eirCode_label.Text = "EirCode";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(194, 68);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(144, 20);
            this.txtFName.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(542, 62);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(144, 20);
            this.txtLName.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(194, 165);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(144, 20);
            this.txtemail.TabIndex = 10;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(542, 165);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(144, 20);
            this.phoneNo.TabIndex = 11;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(194, 255);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(144, 20);
            this.address.TabIndex = 12;
            // 
            // town
            // 
            this.town.Location = new System.Drawing.Point(194, 359);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(144, 20);
            this.town.TabIndex = 14;
            // 
            // eirCode
            // 
            this.eirCode.Location = new System.Drawing.Point(542, 358);
            this.eirCode.Name = "eirCode";
            this.eirCode.Size = new System.Drawing.Size(90, 20);
            this.eirCode.TabIndex = 15;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(139, 445);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(172, 53);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(374, 445);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(172, 53);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxCounty
            // 
            this.comboBoxCounty.FormattingEnabled = true;
            this.comboBoxCounty.Items.AddRange(new object[] {
            "KERRY"});
            this.comboBoxCounty.Location = new System.Drawing.Point(542, 254);
            this.comboBoxCounty.Name = "comboBoxCounty";
            this.comboBoxCounty.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCounty.TabIndex = 18;
            // 
            // addCustomersGroupBox
            // 
            this.addCustomersGroupBox.Controls.Add(this.comboBoxCounty);
            this.addCustomersGroupBox.Controls.Add(this.resetButton);
            this.addCustomersGroupBox.Controls.Add(this.ConfirmButton);
            this.addCustomersGroupBox.Controls.Add(this.eirCode);
            this.addCustomersGroupBox.Controls.Add(this.town);
            this.addCustomersGroupBox.Controls.Add(this.address);
            this.addCustomersGroupBox.Controls.Add(this.phoneNo);
            this.addCustomersGroupBox.Controls.Add(this.txtemail);
            this.addCustomersGroupBox.Controls.Add(this.txtLName);
            this.addCustomersGroupBox.Controls.Add(this.txtFName);
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
            this.Text = "Food Delivery -[Add New Customers]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addCustomersGroupBox.ResumeLayout(false);
            this.addCustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.Label email_labe;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label Town_label;
        private System.Windows.Forms.Label County_label;
        private System.Windows.Forms.Label eirCode_label;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox town;
        private System.Windows.Forms.TextBox eirCode;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox comboBoxCounty;
        private System.Windows.Forms.GroupBox addCustomersGroupBox;
    }
}