using System.ComponentModel.DataAnnotations;

namespace ReelObscuraApp.Web.Views.Movies
{
    public static class EditVM
    {
        public class MovieEditVM
        {
            public int Id { get; set; }

            [Display(Name = "Title")]
            [Required(ErrorMessage = "You must specify a name")]
            public string Title { get; set; }

            [Display(Name = "Description")]
            [Required(ErrorMessage = "You must specify a description")]
            public string Description { get; set; }

            [Display(Name = "Release Year")]
            [Required(ErrorMessage = "You must specify a year")]
            public string ReleaseYear { get; set; }

            [Display(Name = "IMDB URL")]
            [Required(ErrorMessage = "You must enter a URL")]
            [Url(ErrorMessage = "Must be a valid URL.")]
            public string ImdbUrl { get; set; }

            [Display(Name = "Movie Poster")]
            [Required(ErrorMessage = "You must enter a URL to a poster")]
            [Url(ErrorMessage = "Must be a valid URL.")]
            public string MoviePoster { get; set; }

            [Display(Name = "Actors")]
            [Required(ErrorMessage = "You must enter a list of actors")]
            public string Actors { get; set; }

            [Display(Name = "Trailer URL")]
            [Required(ErrorMessage = "You must enter a URL to a trailer")]
            [Url(ErrorMessage = "Must be a valid URL.")]
            public string TrailerUrl { get; set; }
        }
    }
}