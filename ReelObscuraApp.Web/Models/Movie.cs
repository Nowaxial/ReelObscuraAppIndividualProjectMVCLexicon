using System.ComponentModel.DataAnnotations;


namespace ReelObscuraApp.Web.Models
    {
    public class Movie
        {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "You need to enter a title")]
        public string Title { get; set; } = null!;


        [Display(Name = "Description")]
        [Required(ErrorMessage = "You need to enter description")]
        public string Description { get; set; } = null!;


        [Display(Name = "Release Year")]
        [Required(ErrorMessage = "You need to set a year")]
        public string ReleaseYear { get; set; } = null!;


        [Display(Name = "Youtube Id")]
        [Required(ErrorMessage = "You need to enter a Youtube id")]
        public string TrailerUrl { get; set; } = null!;

        [Display(Name = "Movie Poster")]
        [Required(ErrorMessage = "You need to upload a poster")]
        public string MoviePoster { get; set; } = null!;

        [Display(Name = "Imdb URL")]
        [Required(ErrorMessage = "You need to enter a IMDB Url")]
        public string ImdbUrl { get; set; } = null!;

        [Display(Name = "Actors")]
        [Required(ErrorMessage = "You need to add actors")]
        public string[] Actors { get; set; } = null!;
        }
    }