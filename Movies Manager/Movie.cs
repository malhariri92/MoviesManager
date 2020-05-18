using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Manager
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; private set; }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalEarned { get; set; }

        private static string[] genres = {"","Animation", "Action", "Comedy", "Drama", "Horror", "Mystery",
        "Romance","Science Fiction","Western"}; 
        
        public void AssignGenre(int index)
        {
            if(index < 0 || index > 9)
            {
                Genre = genres[0];
            }
            else
            {
                Genre = genres[index];
            }
        }
        public static string[] GetGenresList()
        {
            return genres;
        }
    }
}
