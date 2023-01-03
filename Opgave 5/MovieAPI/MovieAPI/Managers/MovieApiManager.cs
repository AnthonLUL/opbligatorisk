using MovieLibrary;
using System.Xml.Linq;

namespace MovieAPI.Managers
{
    public class MovieApiManager
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie(1, "The Shawshank Redemption", 142, "USA"),
            new Movie(2, "The Godfather", 175, "USA"),
            new Movie(3, "The Godfather: Part II", 202, "USA"),
            new Movie(4, "The Dark Knight", 152, "USA"),
            new Movie(5, "12 Angry Men", 96, "USA")
        };

        public List<Movie> GetAll()
        {
            return Movies;
        }

        public Movie GetById(int id)
        {
            return Movies.Find(movie => movie.Id == id);
        }

        public void PostMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public Movie Post(Movie newMovie)
        {
            newMovie.Id = Movies.Count + 1;
            Movies.Add(newMovie);
            return newMovie;
        }
    }
}
