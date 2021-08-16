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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseFunctions().findallcustomers();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateAndDeleteCust updateAndDeleteCust = new UpdateAndDeleteCust();
            updateAndDeleteCust.txtCustID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateAndDeleteCust.txtFirstName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateAndDeleteCust.txtAddress.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateAndDeleteCust.txtPhoneNo.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateAndDeleteCust.ShowDialog();
            dataGridView1.DataSource = new DatabaseFunctions().findallcustomers();
        }
    }
}
