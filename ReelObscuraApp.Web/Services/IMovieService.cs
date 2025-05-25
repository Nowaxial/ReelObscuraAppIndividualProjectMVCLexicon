namespace ReelObscuraApp.Web.Models
{
    public interface IMovieService
    {
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        Movie[] GetAllMovies();
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
    }
}
