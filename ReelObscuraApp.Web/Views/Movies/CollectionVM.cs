namespace ReelObscuraApp.Web.Views.Movies
{
    public class CollectionVM
    {
        public MovieCollectionVM[] MovieCollectionVMs { get; set; } = null!;

        public class MovieCollectionVM
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
            public required string Description { get; set; } = null!;
            public required string ReleaseYear { get; set; } = null!;
            public required string ImdbUrl { get; set; } = null!;
            public required string MoviePoster { get; set; } = null!;
            public required string[] Actors { get; set; } = null!;
            public required string TrailerUrl { get; set; } = null!;
        }
    }
}
