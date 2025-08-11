using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySYS
{
    public partial class fmCustomers : Form
    {
        public fmCustomers()
        {
            InitializeComponent();
        }

        private void Town_label_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered",
               "Error!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            if (txtLastName.Text.Equals("KERRY"))
            {
                MessageBox.Show("This Type Code Already Exists",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
        }
    }
}
