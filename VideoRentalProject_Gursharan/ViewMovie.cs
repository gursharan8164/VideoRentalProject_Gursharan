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
    public partial class ViewMovie : Form
    {
        public ViewMovie()
        {
            InitializeComponent();
        }

        private void ViewMovie_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseFunctions().findallmovies();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateAndDeleteMovie updateAndDeleteMovie = new UpdateAndDeleteMovie();
            updateAndDeleteMovie.txtMovieID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateAndDeleteMovie.txtTitle.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateAndDeleteMovie.txtRating.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateAndDeleteMovie.txtYear.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateAndDeleteMovie.txtCopies.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateAndDeleteMovie.txtPlot.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateAndDeleteMovie.txtGenre.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateAndDeleteMovie.ShowDialog();
            dataGridView1.DataSource = new DatabaseFunctions().findallmovies();
        }
    }
}
