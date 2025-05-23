using System.ComponentModel.DataAnnotations;

namespace ReelObscuraApp.Web.Views.Movies
{
    public static class CreateVM
    {

        public class MovieCreateVM
        {
            [Display(Name = "Title")]
            [Required(ErrorMessage = "You must specify a name")]
            public required string Title { get; set; }

            [Display(Name = "Description")]
            [Required(ErrorMessage = "You must specify a description")]
            public required string Description { get; set; } = null!;

            [Display(Name = "Release Year")]
            [Required(ErrorMessage = "You must specify a year")]
            public required string ReleaseYear { get; set; } = null!;

            [Display(Name = "IMDB URL")]
            [Required(ErrorMessage = "You must enter a URL")]
            [Url(ErrorMessage = "Must be a valid URL.")]
            public required string ImdbUrl { get; set; } = null!;

            [Display(Name = "Movie Poster")]
            [Required(ErrorMessage = "You must enter a URL to a poster")]
            [Url(ErrorMessage = "Must be a valid URL.")]

            public required string MoviePoster { get; set; } = null!;

            [Display(Name = "Actors")]
            [Required(ErrorMessage = "You must enter a list of actors")]
            public required string Actors { get; set; } = null!;


            [Display(Name = "Trailer URL")]
            [Required(ErrorMessage = "You must enter a URL to a trailer")]
            [Url(ErrorMessage = "Must be a valid URL.")]
            public required string TrailerUrl { get; set; } = null!;
        }
    }
}