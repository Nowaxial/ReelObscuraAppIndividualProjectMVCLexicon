namespace ReelObscuraApp.Web.Views.Movies
{
    public class IndexVM
    {
        public MovieVM[] MovieVMs = null!;

        public class MovieVM
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
            public required string Description { get; set; }
            public required string MoviePoster { get; set; }

        }
    }
}
