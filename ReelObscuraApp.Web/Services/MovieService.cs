using ReelObscuraApp.Web.Models;

namespace ReelObscuraApp.Web.Services
{
    public class MovieService
    {
        private List<Movie> movies = [
             new Movie { Id = 54, Title = "Olle Jonsson", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tortor lectus, auctor in felis nec, pharetra accumsan leo. Vivamus iaculis in ipsum ac tristique. Nam vitae purus at erat bibendum ornare. Aenean dapibus maximus diam suscipit tristique. Nunc efficitur orci ut dui porttitor suscipit. Aenean eu justo sapien. Nulla volutpat venenatis nibh, non pellentesque arcu tincidunt sit amet. Morbi nec turpis finibus, porttitor ipsum ut, fringilla tellus. Donec justo leo, suscipit a dignissim ullamcorper, molestie ut diam. Etiam fringilla ligula nec magna aliquet viverra"},
             new Movie { Id = 589, Title = "Olle Jonsson", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tortor lectus, auctor in felis nec, pharetra accumsan leo. Vivamus iaculis in ipsum ac tristique. Nam vitae purus at erat bibendum ornare. Aenean dapibus maximus diam suscipit tristique. Nunc efficitur orci ut dui porttitor suscipit. Aenean eu justo sapien. Nulla volutpat venenatis nibh, non pellentesque arcu tincidunt sit amet. Morbi nec turpis finibus, porttitor ipsum ut, fringilla tellus. Donec justo leo, suscipit a dignissim ullamcorper, molestie ut diam. Etiam fringilla ligula nec magna aliquet viverra"},
             new Movie { Id = 5498, Title = "Olle Jonsson", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tortor lectus, auctor in felis nec, pharetra accumsan leo. Vivamus iaculis in ipsum ac tristique. Nam vitae purus at erat bibendum ornare. Aenean dapibus maximus diam suscipit tristique. Nunc efficitur orci ut dui porttitor suscipit. Aenean eu justo sapien. Nulla volutpat venenatis nibh, non pellentesque arcu tincidunt sit amet. Morbi nec turpis finibus, porttitor ipsum ut, fringilla tellus. Donec justo leo, suscipit a dignissim ullamcorper, molestie ut diam. Etiam fringilla ligula nec magna aliquet viverra"},
             
            ];

        public void AddMovie(Movie movie)
        {
            movie.Id = false ? 1 : movies.Max(m => m.Id) + 1;
            movies.Add(movie);
        }

        public Movie[] GetAllMovies() => [.. movies.OrderBy(m => m.Title)];

        public Movie GetMovieById(int id) => movies.Single(m => m.Id == id);
    }
}