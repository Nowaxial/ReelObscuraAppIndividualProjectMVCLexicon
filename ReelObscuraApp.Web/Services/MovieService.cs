using ReelObscuraApp.Web.Models;

namespace ReelObscuraApp.Web.Services
{
    public class MovieService
    {
        private List<Movie> movies = [
            new Movie
            {
                Id = 11,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                ReleaseYear = "2010",
                ImdbUrl = "https://www.imdb.com/title/tt1375666/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                Actors = new[] { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" },
                TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM"
            },
            new Movie
            {
                Id = 13,
                Title = "The Matrix",
                Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                ReleaseYear = "1999",
                ImdbUrl = "https://www.imdb.com/title/tt0133093/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDU0Zi00ZjZhLTQ3NzEtYjQ1M2ZmMzQyZWQwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                Actors = new[] { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" },
                TrailerUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU"
            },
            new Movie
            {
                Id = 15,
                Title = "Blade Runner 2049",
                Description = "A young blade runner's discovery of a long-buried secret leads him to track down former blade runner Rick Deckard, who's been missing for thirty years.",
                ReleaseYear = "2017",
                ImdbUrl = "https://www.imdb.com/title/tt1856101/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BNzA1NjBiOTktMzA4Ny00MzQ1LWE1ZGUtZTZjNWIxMGQzNjY5XkEyXkFqcGdeQXVyNjU1OTQ0OTY@._V1_.jpg",
                Actors = new[] { "Ryan Gosling", "Harrison Ford", "Ana de Armas" },
                TrailerUrl = "https://www.youtube.com/watch?v=gCcbXkoyzoU"
            },
            new Movie
            {
                Id = 12,
                Title = "Interstellar",
                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                ReleaseYear = "2014",
                ImdbUrl = "https://www.imdb.com/title/tt0816692/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MzE@._V1_.jpg",
                Actors = new[] { "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain" },
                TrailerUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E"
            },
            new Movie
            {
                Id = 14,
                Title = "Mad Max: Fury Road",
                Description = "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the help of a drifter.",
                ReleaseYear = "2015",
                ImdbUrl = "https://www.imdb.com/title/tt1392190/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BMjM2NjA1ODg0Nl5BMl5BanBnXkFtZTgwNTA2MzQ2NzE@._V1_.jpg",
                Actors = new[] { "Tom Hardy", "Charlize Theron", "Nicholas Hoult" },
                TrailerUrl = "https://www.youtube.com/watch?v=hEJnMQG9ev8"
            },
            new Movie
            {
                Id = 16,
                Title = "Get Out",
                Description = "A young African-American man visits his white girlfriend's family estate, where he becomes ensnared in a more sinister real reason for the invitation.",
                ReleaseYear = "2017",
                ImdbUrl = "https://www.imdb.com/title/tt5052448/",
                MoviePoster = "https://m.media-amazon.com/images/M/MV5BOTMyYzU4ZGUtZDJjNi00ZjQ1LWEwMjEtZGUxZmM2ZTA3ZjQ4XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                Actors = new[] { "Daniel Kaluuya", "Allison Williams", "Bradley Whitford" },
                TrailerUrl = "https://www.youtube.com/watch?v=sRfnevzMx8E"
            }
        ];

        public void AddMovie(Movie movie)
        {
            if (movies.Any(m => m.Title == movie.Title))
                throw new InvalidOperationException("The movie already exists");

            movie.Id = movies.Count == 0 ? 1 : movies.Max(m => m.Id) + 1;
            movies.Add(movie);
        }

        public Movie[] GetAllMovies() => [.. movies.OrderBy(m => m.Title)];

        public Movie GetMovieById(int id) => movies.Single(m => m.Id == id);
    }
}