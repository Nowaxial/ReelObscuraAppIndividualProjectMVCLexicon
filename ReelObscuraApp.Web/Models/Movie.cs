using System.ComponentModel.DataAnnotations;

namespace ReelObscuraApp.Web.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;


        public string Description { get; set; } = null!;


        public string ReleaseYear { get; set; } = null!;


        public string TrailerUrl { get; set; } = null!;


        public string MoviePoster { get; set; } = null!;


        public string ImdbUrl { get; set; } = null!;


        public string[] Actors { get; set; } = null!;
    }
}