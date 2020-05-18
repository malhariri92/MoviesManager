using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Manager
{
    class MoviesManager
    {
        private static List<Movie> movies;

        // SQL string for querying the Movies table 
        private static string readStr = "SELECT  Id, Title,  Year , Director, Genre," +
              " RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";
        //SQL string for creating a new movie
        private static string createStr = "INSERT INTO Movies (Title, Year, Director, Genre," +
            " RottenTomatoesScore,TotalEarned) "
                        + "VALUES (@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)";
        // SQL string for updating a movie 
        private static string updateStr = $"UPDATE dbo.Movies " +
                    "SET Title = @Title, Year =  @Year, Director = @Director, Genre = @Genre," +
                    "RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned " +
                    "WHERE Id = @Id";
        // SQL string for deleting a movie
        private static string deleteStr = "DELETE FROM Movies WHERE Id = @Id";

        // To read the connection string from the configuration file
        private static string connectionString = ConfigurationManager.ConnectionStrings["MoviesDB"]?.ConnectionString;

        // To query the Movies table
        // Returns a List of movies
        public static List<Movie> GetMovies()
        {
            movies = new List<Movie>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(readStr, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new Movie();

                                movie.Id = reader.GetInt32(0);
                                movie.Title = reader.GetString(1);
                                movie.Year = reader.GetInt32(2);
                                movie.Director = reader.GetString(3);
                                movie.AssignGenre(reader.GetInt32(4));
                                if (!reader.IsDBNull(5))
                                {
                                    movie.RottenTomatoesScore = reader.GetInt32(5);
                                }
                                else
                                {
                                    movie.RottenTomatoesScore = -1;
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    movie.TotalEarned = reader.GetDecimal(6);
                                }
                                else
                                {
                                    movie.TotalEarned = -1;
                                }
                                movies.Add(movie);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return movies;
        }
        // To add a new movie to the Movies table
        // Returns the number of rows affected
        public static int AddMovie(Movie movie)
        {
            int result = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(createStr, connection))
                {
                    command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = movie.Title;
                    command.Parameters.Add("Year", SqlDbType.Int).Value = movie.Year;
                    command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = movie.Director;
                    command.Parameters.Add("Genre", SqlDbType.Int).Value = Array.IndexOf(Movie.GetGenresList(), movie.Genre);

                    // Checks if the rotten tomatoes score was left empty
                    
                    if (movie.RottenTomatoesScore == -1)
                    {
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = DBNull.Value;              
                    }
                    else
                    {
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = movie.RottenTomatoesScore;
                    }

                    // Checks if the total earned was left empty
                    if (movie.TotalEarned == -1)
                    {
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = DBNull.Value;                       
                    }
                    else
                    {
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = movie.TotalEarned;
                    }
                    
                    connection.Open();
                    result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        // To update a movie in the Movies table
        // Returns the number of rows affected
        public static int UpdateMovie(Movie movie)
        {
            int result;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(updateStr, connection))
                {
                    command.Parameters.Add("Id", SqlDbType.Int).Value = movie.Id;
                    command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = movie.Title;
                    command.Parameters.Add("Year", SqlDbType.Int).Value = movie.Year;
                    command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = movie.Director;
                    command.Parameters.Add("Genre", SqlDbType.Int).Value = Array.IndexOf(Movie.GetGenresList(), movie.Genre);

                    // Checks if the rotten tomatoes score was left empty
                    if (movie.RottenTomatoesScore == -1)
                    {
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = movie.RottenTomatoesScore;
                    }
                    // Checks if the total earned was left empty
                    if (movie.TotalEarned == -1)
                    {
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = movie.TotalEarned;
                    }
                    connection.Open();
                    result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                result = 0;
                Console.WriteLine(ex.StackTrace);
            }

            return result;
        }
        // To check if a movie already exist in the movies table
        // Return the movie if found otherwise returns a null movie
        public static Movie Find(string titleToFind)
        {
            Movie movieToFind = null;
            List<Movie> moviesList = GetMovies();
            foreach (Movie movie in moviesList)
            {
                if (titleToFind.Equals(movie.Title, StringComparison.OrdinalIgnoreCase))
                {
                    movieToFind = movie;
                }

            }
            return movieToFind;
        }
        // To delete a movie from the Movies table 
        // Returns the number of rows affected
        public static int DeleteMovie(int Id)
        {
            int result;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(deleteStr, connection))
                {
                    command.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                    connection.Open();
                    result = command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                result = 0;
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
