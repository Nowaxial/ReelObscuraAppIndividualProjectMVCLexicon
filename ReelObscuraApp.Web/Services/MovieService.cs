using ReelObscuraApp.Web.Models;

namespace ReelObscuraApp.Web.Services
{
    public class MovieService
    {
        private List<Movie> movies = [
            new Movie
    {
        Id = 1,
        Title = "The Room",
        Description = "A banker's seemingly perfect life is disrupted when his fiancée begins an affair with his best friend.",
        ReleaseYear = "2003",
        ImdbUrl = "https://www.imdb.com/title/tt0368226/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BMTg4MTU1MzgwOV5BMl5BanBnXkFtZTcwNjM1MTAwMQ@@._V1_.jpg",
        Actors = new[] { "Tommy Wiseau", "Juliette Danielle", "Greg Sestero" },
        TrailerUrl = "https://www.youtube.com/watch?v=9-dIdFXeFhs"
    },
    new Movie
    {
        Id = 2,
        Title = "Eraserhead",
        Description = "A man is left to care for his grossly deformed child in a dystopian industrial wasteland.",
        ReleaseYear = "1977",
        ImdbUrl = "https://www.imdb.com/title/tt0074486/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BMDExYzg5ZWItOTNhOC00OTAxLThjODQtODliYmJhODk1ZjY3XkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_.jpg",
        Actors = new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" },
        TrailerUrl = "https://www.youtube.com/watch?v=wR3G5l4xXz8"
    },
    new Movie
    {
        Id = 3,
        Title = "Santa Sangre",
        Description = "A former circus artist escapes from a mental hospital to rejoin his armless mother.",
        ReleaseYear = "1989",
        ImdbUrl = "https://www.imdb.com/title/tt0098253/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BNzFjOWYzMDAtYTY0MC00ZDE0LTk2YzUtYjJkM2JjYWI4MGFjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
        Actors = new[] { "Axel Jodorowsky", "Blanca Guerra", "Guy Stockwell" },
        TrailerUrl = "https://www.youtube.com/watch?v=UCrI4ZT3GZU"
    },
    new Movie
    {
        Id = 4,
        Title = "Tetsuo: The Iron Man",
        Description = "A businessman accidentally kills a metal fetishist and finds himself turning into a grotesque hybrid of flesh and metal.",
        ReleaseYear = "1989",
        ImdbUrl = "https://www.imdb.com/title/tt0096251/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BZjY5YjVkN2QtYjM5Yy00MGUyLWIyOWItYmU5NmY1ZTcxODM0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
        Actors = new[] { "Tomorowo Taguchi", "Kei Fujiwara", "Nobu Kanaoka" },
        TrailerUrl = "https://www.youtube.com/watch?v=4JZQ0XEn3G0"
    },
    new Movie
    {
        Id = 5,
        Title = "The Holy Mountain",
        Description = "A Christlike figure wanders through bizarre, grotesque scenarios filled with religious and sacrilegious imagery.",
        ReleaseYear = "1973",
        ImdbUrl = "https://www.imdb.com/title/tt0071615/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BN2IyNTE4YzUtZWU0Mi00MGIwLTgyMmQtMzQ4YzQxYWNlYWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
        Actors = new[] { "Alejandro Jodorowsky", "Horacio Salinas", "Zamira Saunders" },
        TrailerUrl = "https://www.youtube.com/watch?v=9yGxwX9KqUY"
    },
    new Movie
    {
        Id = 6,
        Title = "Begotten",
        Description = "God disembowels himself with a straight razor, and the Goddess emerges from his corpse to give birth to Mother Earth.",
        ReleaseYear = "1989",
        ImdbUrl = "https://www.imdb.com/title/tt0099108/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BMjA3MjE1NDEtNjk0OS00OGY3LTkxMjktOThmYjIhYzg4YTFiXkEyXkFqcGdeQXVyMzU0NzkwMDg@._V1_.jpg",
        Actors = new[] { "Brian Salzberg", "Donna Dempsey", "Stephen Charles Barry" },
        TrailerUrl = "https://www.youtube.com/watch?v=4QYh-Qn9L1w"
    },
    new Movie
    {
        Id = 7,
        Title = "Gummo",
        Description = "A series of vignettes that portray the miserable lives of the residents of a small Ohio town.",
        ReleaseYear = "1997",
        ImdbUrl = "https://www.imdb.com/title/tt0119237/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BZjI5ZTNiNzAtYzE1Yi00NmU5LThlY2ItOTQyZGFmOWY1YzA1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
        Actors = new[] { "Jacob Reynolds", "Nick Sutton", "Jacob Sewell" },
        TrailerUrl = "https://www.youtube.com/watch?v=6vVw8kqmX2E"
    },
    new Movie
    {
        Id = 8,
        Title = "Videodrome",
        Description = "The CEO of a television station begins to see his life and the future of media spin out of control in a very unusual fashion.",
        ReleaseYear = "1983",
        ImdbUrl = "https://www.imdb.com/title/tt0086541/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BZTk1NjU5YTUtOWI2Ni00ODFkLTlhNTMtN2Q0Y2VkNjVjZTE5XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_.jpg",
        Actors = new[] { "James Woods", "Deborah Harry", "Sonja Smits" },
        TrailerUrl = "https://www.youtube.com/watch?v=wXi1dB0Z6S8"
    },
    new Movie
    {
        Id = 9,
        Title = "El Topo",
        Description = "A mysterious black-clad gunfighter wanders a mystical Western landscape encountering multiple bizarre characters.",
        ReleaseYear = "1970",
        ImdbUrl = "https://www.imdb.com/title/tt0067866/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BMTk0NDI0OTQ3OF5BMl5BanBnXkFtZTcwODQzOTQyMQ@@._V1_.jpg",
        Actors = new[] { "Alejandro Jodorowsky", "Brontis Jodorowsky", "José Legarreta" },
        TrailerUrl = "https://www.youtube.com/watch?v=4kUo4kQx7B4"
    },
    new Movie
    {
        Id = 10,
        Title = "Possession",
        Description = "A woman starts exhibiting increasingly disturbing behavior after asking her husband for a divorce.",
        ReleaseYear = "1981",
        ImdbUrl = "https://www.imdb.com/title/tt0082933/",
        MoviePoster = "https://m.media-amazon.com/images/M/MV5BMTQ5ODIzODQyNF5BMl5BanBnXkFtZTcwNDM4MjU1MQ@@._V1_.jpg",
        Actors = new[] { "Isabelle Adjani", "Sam Neill", "Margit Carstensen" },
        TrailerUrl = "https://www.youtube.com/watch?v=4DHsGjqX3h8"
    }


        ];

        public void AddMovie(Movie movie)
        {
            if (movies.Any(m => m.Title == movie.Title))
                throw new InvalidOperationException("The movie already exixts");

            movie.Id = movies.Count == 0 ? 1 : movies.Max(m => m.Id) + 1;
            movies.Add(movie);
        }

        public Movie[] GetAllMovies() => [.. movies.OrderBy(m => m.Title)];

        public Movie GetMovieById(int id) => movies.Single(m => m.Id == id);
    }
}