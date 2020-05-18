using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = MoviesManager.GetMovies();
            dataGrid.Columns[6].DefaultCellStyle.Format = "C";
            dataGrid.Columns[5].HeaderText = "Rotten Tomatoes Score";
            dataGrid.Columns[6].HeaderText = "Total Box Office";

            // Checks if the of the RottenTomatoesScore or the TotalEarned is -1
            // Set the value to null
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if(row.Cells[5].Value.ToString() == "-1")
                {
                    row.Cells[5].Value = null;
                }

                if (row.Cells[6].Value.ToString() == "-1")
                {
                    row.Cells[6].Value = null;
                }
            }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            Main_Load(null, EventArgs.Empty);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMovie = new UpdateMovie();
            updateMovie.ShowDialog();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            DeleteMovie deleteMovie = new DeleteMovie();
            deleteMovie.ShowDialog();
        }
    }
}
