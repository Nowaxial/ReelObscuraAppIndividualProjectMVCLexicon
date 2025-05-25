using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using ReelObscuraApp.Web.Models;
using ReelObscuraApp.Web.Services;
using ReelObscuraApp.Web.Views.Movies;

namespace ReelObscuraApp.Web.Controllers
{
    public class MoviesController(IMovieService service) : Controller
    {
        [Route("NotFound/{statusCode}")]
        public IActionResult NotFound(int statusCode)
        {
            return View();
        }

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


        // This action is for testing purposes to trigger an error page
        [HttpGet("/trigger-error")]
        public IActionResult TriggerError()
        {
            throw new Exception("Test exception for error page");
        }

        [HttpGet("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            var movie = service.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }

            var viewModel = new EditVM.MovieEditVM
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ReleaseYear = movie.ReleaseYear,
                ImdbUrl = movie.ImdbUrl,
                MoviePoster = movie.MoviePoster,
                Actors = string.Join(", ", movie.Actors),
                TrailerUrl = movie.TrailerUrl
            };

            return View(viewModel);
        }

        [HttpPost("/edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EditVM.MovieEditVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var existingMovie = service.GetMovieById(id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            // Uppdatera befintlig film
            existingMovie.Title = viewModel.Title;
            existingMovie.Description = viewModel.Description;
            existingMovie.ReleaseYear = viewModel.ReleaseYear;
            existingMovie.ImdbUrl = viewModel.ImdbUrl;
            existingMovie.MoviePoster = viewModel.MoviePoster;
            existingMovie.Actors = viewModel.Actors.Split(',').Select(a => a.Trim()).ToArray();
            existingMovie.TrailerUrl = viewModel.TrailerUrl;

            service.UpdateMovie(existingMovie);
            return RedirectToAction(nameof(Details), new { id = existingMovie.Id });
        }
    }
}