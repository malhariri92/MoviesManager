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
    public partial class AddMovie : Form
    {
        private int rottenTomatoes;
        private decimal totalEarned;
        private int year;
        public AddMovie()
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

        private void AddMovie_Load(object sender, EventArgs e)
        {
            genreBx.DataSource = Movie.GetGenresList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {                   
            int result;

            if (IsValid())
            {
                if (MoviesManager.Find(titleBx.Text) == null)
                {
                    Movie movieToAdd = new Movie();
                    movieToAdd.Title = titleBx.Text;
                    movieToAdd.Year = year;
                    movieToAdd.Director = directorBx.Text;
                    movieToAdd.AssignGenre(genreBx.SelectedIndex);

                    // Gives the RottenTomatoesScore a negative value when left empty
                    // When it is negative, the variable will be null in the database
                    if(rottenBx.Text == "")
                    {
                        rottenTomatoes = -1;
                    }
                    movieToAdd.RottenTomatoesScore = rottenTomatoes;

                    // Gives the TotalEarned a negative value when left empty
                    // When it is negative, the variable will be null in the database
                    if (earningBx.Text == "")
                    {
                        totalEarned = -1;
                    }
                    movieToAdd.TotalEarned = totalEarned;

                    result = MoviesManager.AddMovie(movieToAdd);
                    if (result <= 0)
                    {
                        MessageBox.Show("An error has occurred. Plaese try again later."
                            , "Cannot Add Movie");
                    }
                    else
                    {
                        MessageBox.Show("New Movie has been added to the Movies database.", "Success");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot add " + titleBx.Text + " because it already exists in the database"
                            , "Cannot Add Movie");
                }
            }
            
        }

        private bool IsValid()
        {
           if( titleBx.Text == "")
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
           else if(rottenBx.Text != "" && !Int32.TryParse(rottenBx.Text, out rottenTomatoes))
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
