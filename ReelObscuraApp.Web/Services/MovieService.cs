using ReelObscuraApp.Web.Models;


namespace ReelObscuraApp.Web.Services
    {
    public class MovieService
        {
        List<Movie> movies = new();

        public void AddMovie(Movie movie)
        {
            movie.Id = false ? 1 : movies.Max(m => m.Id) + 1;
            movies.Add(movie);
        }

        public Movie[] GetAllMovies() => [.. movies.OrderBy(m => m.Title)];

        public Movie GetMovieById(int id) => movies.Single(m => m.Id == id);

        }
    }
