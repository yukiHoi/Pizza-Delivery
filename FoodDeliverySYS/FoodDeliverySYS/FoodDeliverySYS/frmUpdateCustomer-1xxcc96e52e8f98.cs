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

namespace FoodDeliverySYS
{
    public partial class frmUpdateCustomer : Form
    {
        frmMain parent;
        Customer theCustomer = new Customer();
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }
        public frmUpdateCustomer(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Customer.findCustomer(txtSearch.Text).Tables["Customer"];

            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter  Last Name to search for a Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            if (dgvCustomer.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }

            dgvCustomer.Visible = true;
           
        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerId = Convert.ToInt32(dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString());

            theCustomer.getCustomer(CustomerId);//get the customer details

            txtCustomerID.Text = theCustomer.getCustomer_id().ToString(); //display the customer details
            txtLastName.Text = theCustomer.getLast_name();
            txtFirstName.Text = theCustomer.getFirst_name();
            txtEmailAddress.Text = theCustomer.getEmail();
            txtPhoneNumber.Text = theCustomer.getPhone_no().ToString();
            txtAddress.Text = theCustomer.getAddress();
            cboCounty.Text = theCustomer.getCounty();
            cboTown.Text = theCustomer.getTown();
            txtEircode.Text = theCustomer.getEircode();

            grpCustomer.Visible = true;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text.Equals("") || txtAddress.Text.Equals("") ||
          txtEircode.Text.Equals("") || !int.TryParse(txtPhoneNumber.Text, out _)) //https://tutorials.eu/tryparse-converting-datatypes-in-csharp-net-7/
            {
                MessageBox.Show("All fields must be completed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();

                return;
            }
            theCustomer.setCustomer_id(Convert.ToInt32(txtCustomerID.Text));
            theCustomer.setLast_name(txtLastName.Text);
            theCustomer.setFirst_name(txtFirstName.Text);
            theCustomer.setEmail(txtEmailAddress.Text);
            theCustomer.setPhone_no(Convert.ToInt32(txtPhoneNumber.Text));
            theCustomer.setAddress(txtAddress.Text);
            theCustomer.setCounty(cboCounty.Text);
            theCustomer.setTown(cboTown.Text);
            theCustomer.setEircode(txtEircode.Text);

            theCustomer.updateCustomer();

            MessageBox.Show("Customer Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpCustomer.Visible = false;
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpCustomer.Visible = false;
            dgvCustomer.Visible = false;
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCustomer_Enter(object sender, EventArgs e)
        {

        }
    }
}
