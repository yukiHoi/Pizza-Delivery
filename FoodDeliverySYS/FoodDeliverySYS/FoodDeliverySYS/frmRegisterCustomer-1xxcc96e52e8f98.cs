using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace FoodDeliverySYS
{
    public partial class frmRegisterCustomer : Form
    {
        frmMain parent;
        public frmRegisterCustomer()
        {
            InitializeComponent();
           
        }
        public frmRegisterCustomer(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {          
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void registerCustomersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Customer.getNextCustomer_id().ToString("00000"); //get the next customer id and display it in the textbox

        }
   

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") ||
          txtEmailAddress.Text.Equals("") || txtAddress.Text.Equals("") ||
          cboCounty.SelectedIndex ==-1 || cboTown.SelectedIndex == -1 ||
          txtEircode.Text.Equals("") || !int.TryParse(txtPhoneNumber.Text, out _)) //https://tutorials.eu/tryparse-converting-datatypes-in-csharp-net-7/
            {
                MessageBox.Show("All fields must be completed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();

                return;
            }
          
    
            Customer Customer = new Customer(Convert.ToInt32(txtCustomerID.Text),txtFirstName.Text,txtLastName.Text,txtEmailAddress.Text,
                Convert.ToInt32(txtPhoneNumber.Text),txtAddress.Text,cboCounty.Text, cboTown.Text,txtEircode.Text);
            
            Customer.addCustomer();

            MessageBox.Show("Customer  registered successfully!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFirstName.Clear();
            txtFirstName.Focus();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            cboCounty.SelectedIndex = -1;
            cboTown.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhoneNumber.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
            cboCounty.SelectedIndex = -1;
            cboTown.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
