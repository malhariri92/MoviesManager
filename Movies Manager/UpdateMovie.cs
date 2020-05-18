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
    public partial class UpdateMovie : Form
    {
        private int rottenTomatoes;
        private decimal totalEarned;
        private int year;
        public UpdateMovie()
        {
            InitializeComponent();
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

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            genreBx.DataSource = Movie.GetGenresList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("The movie you entered cannot be found, please try again", "Not Found");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int result;

            Movie movieToUpdate = MoviesManager.Find(titleBx.Text);

            if (IsValid() && movieToUpdate != null)
            {
                movieToUpdate.Title = titleBx.Text;
                movieToUpdate.Year = year;
                movieToUpdate.Director = directorBx.Text;
                movieToUpdate.AssignGenre(genreBx.SelectedIndex);
                if (rottenBx.Text == "")
                {
                    rottenTomatoes = -1;
                }
                movieToUpdate.RottenTomatoesScore = rottenTomatoes;
                if (earningBx.Text == "")
                {
                    totalEarned = -1;
                }
                movieToUpdate.TotalEarned = totalEarned;

                result = MoviesManager.UpdateMovie(movieToUpdate);

                if (result <= 0)
                {
                    MessageBox.Show("Cannot update movie at this time. Please try again later."
                        , "Cannot Update");
                }
                else
                {
                    MessageBox.Show("Movie has been successfuly updated.", "Success");
                }
            }
        }

        private bool IsValid()
        {
            if (titleBx.Text == "")
            {
                titleBx.BackColor = Color.Red;
                MessageBox.Show("Movie title is required. Please enter movie tilte", "Input Left Empty");
                return false;
            }
            else if (yearBx.Text == "" || !Int32.TryParse(yearBx.Text, out year))
            {
                yearBx.BackColor = Color.Red;
                MessageBox.Show("Invalid Year. Please re-enter movie year", "Invalid Year");
                return false;
            }
            else if (directorBx.Text == "")
            {
                directorBx.BackColor = Color.Red;
                MessageBox.Show("Movie director is required. Please enter director name", "Input Left Empty");
                return false;
            }
            else if (genreBx.SelectedIndex == 0)
            {
                genreBx.BackColor = Color.Red;
                MessageBox.Show("Please select genre type", "Input Left Empty");
                return false;
            }
            else if (rottenBx.Text != "" && !Int32.TryParse(rottenBx.Text, out rottenTomatoes))
            {
                rottenBx.BackColor = Color.Red;
                MessageBox.Show("Please enter a valid amount", "Invalid Input");
                return false;
            }
            else if (earningBx.Text != "" && !Decimal.TryParse(earningBx.Text, out totalEarned))
            {
                earningBx.BackColor = Color.Red;
                MessageBox.Show("Please enter a valid amount", "Invalid Input");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void titleBx_TextChanged(object sender, EventArgs e)
        {
            titleBx.BackColor = Color.White;
        }

        private void yearBx_TextChanged(object sender, EventArgs e)
        {
            yearBx.BackColor = Color.White;
        }

        private void directorBx_TextChanged(object sender, EventArgs e)
        {
            directorBx.BackColor = Color.White;
        }

        private void genreBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreBx.BackColor = Color.White;
        }
    }
}
