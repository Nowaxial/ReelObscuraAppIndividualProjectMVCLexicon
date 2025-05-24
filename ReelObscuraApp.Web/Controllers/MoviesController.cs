using Microsoft.AspNetCore.Mvc;
using ReelObscuraApp.Web.Models;
using ReelObscuraApp.Web.Services;
using ReelObscuraApp.Web.Views.Movies;
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
                MovieVMs = [.. model
                .Select(e => new IndexVM.MovieVM()
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description = e.Description,
                    MoviePoster = e.MoviePoster
                })]
            };
            return View(viewModel);
        }

        [HttpGet("/create")]
        public IActionResult Create() => View();

        [HttpPost("/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateVM.MovieCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            Movie movie = new()
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                ReleaseYear = viewModel.ReleaseYear,
                ImdbUrl = viewModel.ImdbUrl,
                MoviePoster = viewModel.MoviePoster,
                Actors = viewModel.Actors.Split(',').Select(a => a.Trim()).ToArray(),
                TrailerUrl = viewModel.TrailerUrl
            };

            service.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/details/{id}")]
        public IActionResult Details(int id)
        {
            var movie = service.GetMovieById(id);
            var viewModel = new DetailsVM()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ReleaseYear = movie.ReleaseYear,
                ImdbUrl = movie.ImdbUrl,
                MoviePoster = movie.MoviePoster,
                Actors = movie.Actors,
                TrailerUrl = movie.TrailerUrl
            };
            return View(viewModel);
        }

        [HttpGet("/collection")]
        public IActionResult Collection()
        {
            var model = service.GetAllMovies();
            var viewModel = new CollectionVM()
            {
                MovieCollectionVMs = [.. model
                .Select(e => new CollectionVM.MovieCollectionVM()
                {
                    Id = e.Id,
                    Title = e.Title,
                    Description = e.Description,
                    ReleaseYear = e.ReleaseYear,
                    ImdbUrl = e.ImdbUrl,
                    MoviePoster = e.MoviePoster,
                    Actors = e.Actors,
                    TrailerUrl = e.TrailerUrl
                })]
            };
            return View(viewModel);
        }
    }
}