namespace ReelObscuraApp.Web.Models
{
    public interface IMovieService
    {
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        Movie[] GetAllMovies();
    }
}
