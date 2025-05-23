using Microsoft.AspNetCore.Mvc;
using ReelObscuraApp.Web.Models;
using ReelObscuraApp.Web.Services;
using ReelObscuraApp.Web.Views.Movie;
using System.Reflection;

namespace ReelObscuraApp.Web.Controllers
{
    public class MoviesController(MovieService service) : Controller
    {


        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = service.GetAllMovies();
            var viewModel = new IndexVM()
            {
                MovieVMs = model
                .Select(e => new IndexVM.MovieVM()
                {
                    Id = e.Id,
                    Title = e.Title,
                    //Description = e.Description,

                })
                .ToArray()
            };
            return View(viewModel);
        }

        [HttpGet("/create")]
        public IActionResult Create() => View();

        [HttpPost("create")]
        public IActionResult Add(Movie movie)
        {
            if (!ModelState.IsValid)
                return View();

            service.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/details/{id}")]
        public IActionResult Details(int id) => View(service.GetMovieById(id));

        [HttpGet("/details")]

        public IActionResult Details() => View();
    }
}