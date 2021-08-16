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
    public partial class IssueMovie : Form
    {
        private string Id;
        public IssueMovie()
        {
            InitializeComponent();
        }
        public IssueMovie(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            comboBox1.SelectedValue = Id;
        }
        private void IssueMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDBDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.movieRentalDBDataSet.Movies);
            // TODO: This line of code loads data into the 'movieRentalDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.movieRentalDBDataSet.Customer);

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "")
            {
                MessageBox.Show("Enter valid Customer ID");
            }
            else
            {
                DatabaseFunctions database = new DatabaseFunctions();
                database.addrentalrecord(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text));
                MessageBox.Show("Movie Rented");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstname.Text = "";
            address.Text = "";
            phoneno.Text = "";

            DataTable table = new DatabaseFunctions().findcustomerbyid(comboBox2.SelectedValue.ToString());

            if (table.Rows.Count > 0)
            {
                firstname.Text = table.Rows[0]["Name"].ToString();
                address.Text = table.Rows[0]["Address"].ToString();
                phoneno.Text = table.Rows[0]["Phone"].ToString();
            }
        }
    }
}
