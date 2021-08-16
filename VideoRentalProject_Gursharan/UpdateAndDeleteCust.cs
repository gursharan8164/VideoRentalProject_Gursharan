using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject_Gursharan
{
    public partial class UpdateAndDeleteCust : Form
    {
        public UpdateAndDeleteCust()
        {
            InitializeComponent();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            DatabaseFunctions database = new DatabaseFunctions();
            database.editcustomer(txtFirstName.Text,  txtAddress.Text, txtPhoneNo.Text, txtCustID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDaleteCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
