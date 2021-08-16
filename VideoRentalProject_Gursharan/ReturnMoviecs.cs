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
    public partial class ReturnMoviecs : Form
    {
        public ReturnMoviecs()
        {
            InitializeComponent();
            dataGridView1.DataSource = new DatabaseFunctions().getpendingrentals();
        }

        private void ReturnMoviecs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DatabaseFunctions database = new DatabaseFunctions();
                string rmid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                database.updatereturnrecord(Convert.ToDateTime(DateTime.Now.ToString()), rmid);
                MessageBox.Show("Movie Returned");
                dataGridView1.DataSource = new DatabaseFunctions().getpendingrentals();
            }
        }
    }
}
