using lab1movies.Factories;
using lab1movies.Models;
using lab1movies.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab1movies.Controlers
{
    public class MoviesController : Controller
    {
        private readonly MovieService _rentalService;

        public MoviesController(MovieService rentalService)
        {
            _rentalService = rentalService;
        }
        public IActionResult Index()
        {
            return View(_rentalService.GetMovies());
        }
        public IActionResult Details(int id)
        {
            Movie? movie = _rentalService.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        [HttpPost]
        public IActionResult Order(int movieId, string language)
        {
            try
            {
                MoviePackage package =
                    _rentalService.CreatePackage(movieId, language);

                return View("OrderConfirmation", package);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
