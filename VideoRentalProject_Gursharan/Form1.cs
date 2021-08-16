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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowDialog(new AddCustomer() { StartPosition = FormStartPosition.CenterScreen });
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void addMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
            addMovie.Hide();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer viewCustomer = new ViewCustomer();
            viewCustomer.ShowDialog();
        }

        private void viewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMovie viewMovie = new ViewMovie();
            viewMovie.ShowDialog();
        }

        private void issueMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueMovie issueMovie = new IssueMovie();
            issueMovie.ShowDialog();
        }

        private void returnMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnMoviecs returnMovie = new ReturnMoviecs();
            returnMovie.ShowDialog();
        }

        private void ourTopCustomerMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
