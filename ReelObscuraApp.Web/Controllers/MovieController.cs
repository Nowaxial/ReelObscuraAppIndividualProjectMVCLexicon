using ReelObscuraApp.Web.Models;
using ReelObscuraApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ReelObscuraApp.Web.Controllers
{
    public class MovieController : Controller
    {
        private static MovieService movieService = new MovieService();

        [HttpGet("/")]
        public IActionResult Index() => View(movieService.GetAllMovies());

        [HttpGet("/create")]
        public IActionResult Create() => View();

        [HttpPost("create")]
        public IActionResult Add(Movie movie)
        {
            if (!ModelState.IsValid)
                return View();

            movieService.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/details/{id}")]
        public IActionResult Details(int id) => View(movieService.GetMovieById(id));

        [HttpGet("/details")]

        public IActionResult Details() => View();
    }
}