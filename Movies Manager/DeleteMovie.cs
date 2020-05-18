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
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = ((ComboBox)c).Items[0];
                }

            }
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            genreBx.DataSource = Movie.GetGenresList();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            Movie movie = MoviesManager.Find(titleBx.Text);
            if (movie != null)
            {
                titleBx.Text = movie.Title;
                yearBx.Text = movie.Year.ToString();
                directorBx.Text = movie.Director;
                genreBx.SelectedItem = movie.Genre;
                if (movie.RottenTomatoesScore != -1)
                {
                    rottenBx.Text = movie.RottenTomatoesScore.ToString();
                }
                if (movie.TotalEarned != -1)
                {
                    earningBx.Text = movie.TotalEarned.ToString();
                }
            }
            else
            {
                MessageBox.Show("Movie not found. Please re-enter movie title and try again.", "Not Found");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this movie?",
                "Confirm Delete",MessageBoxButtons.YesNo);

            Movie movie = MoviesManager.Find(titleBx.Text);

            if (confirm == DialogResult.Yes)
            {
                if (movie != null)
                {
                    int result = MoviesManager.DeleteMovie(movie.Id);
                    if (result <= 0)
                    {
                        MessageBox.Show("An Error has occcurred, please try again", "Error");
                    }
                    else
                    {
                        MessageBox.Show("The movie has been successfuly deleted", "Movie Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("The title you entered does not exist in the database."
                        , "Not Found");
                }
                
            }            
        }       
    }
}
