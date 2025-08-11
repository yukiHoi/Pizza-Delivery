namespace FoodDeliverySYS
{
    partial class fmCustomersOrderHistory
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
            this.orderHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.IDSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OrderID = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.orderHistoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderHistoryGroupBox
            // 
            this.orderHistoryGroupBox.Controls.Add(this.viewButton);
            this.orderHistoryGroupBox.Controls.Add(this.deleteButton);
            this.orderHistoryGroupBox.Controls.Add(this.productName);
            this.orderHistoryGroupBox.Controls.Add(this.OrderID);
            this.orderHistoryGroupBox.Controls.Add(this.textBox1);
            this.orderHistoryGroupBox.Controls.Add(this.IDSearch);
            this.orderHistoryGroupBox.Location = new System.Drawing.Point(73, 23);
            this.orderHistoryGroupBox.Name = "orderHistoryGroupBox";
            this.orderHistoryGroupBox.Size = new System.Drawing.Size(612, 489);
            this.orderHistoryGroupBox.TabIndex = 0;
            this.orderHistoryGroupBox.TabStop = false;
            this.orderHistoryGroupBox.Text = "groupBox1";
            // 
            // IDSearch
            // 
            this.IDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSearch.Location = new System.Drawing.Point(123, 294);
            this.IDSearch.Name = "IDSearch";
            this.IDSearch.Size = new System.Drawing.Size(337, 26);
            this.IDSearch.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(123, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 26);
            this.textBox1.TabIndex = 23;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderID.Location = new System.Drawing.Point(118, 89);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 25);
            this.OrderID.TabIndex = 24;
            this.OrderID.Text = "Order ID";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(118, 241);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(158, 25);
            this.productName.TabIndex = 25;
            this.productName.Text = "product Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(326, 396);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 53);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(87, 396);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(172, 53);
            this.viewButton.TabIndex = 27;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // fmCustomersOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.orderHistoryGroupBox);
            this.Name = "fmCustomersOrderHistory";
            this.Text = "fmCustomersOrderHistory";
            this.orderHistoryGroupBox.ResumeLayout(false);
            this.orderHistoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox orderHistoryGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IDSearch;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewButton;
    }
}