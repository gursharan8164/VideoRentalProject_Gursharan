﻿using System;
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
    public partial class UpdateAndDeleteMovie : Form
    {
        public UpdateAndDeleteMovie()
        {
            InitializeComponent();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(txtYear.Text, out a))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }
                DatabaseFunctions database = new DatabaseFunctions();
                database.editmovie(txtRating.Text, txtTitle.Text, txtYear.Text, txtCopies.Text, rental.ToString(), txtPlot.Text, txtGenre.Text, txtMovieID.Text);
                MessageBox.Show("Movie Updated");
                Dispose();
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            DatabaseFunctions database = new DatabaseFunctions();
            database.deletemovie(txtMovieID.Text);
            MessageBox.Show("Movie Deleted");
            Dispose();
        }
    }
}
