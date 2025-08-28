using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CineMini.Models;

namespace CineMini.Controllers 
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET /movies
        [HttpGet("movies")]
        public IActionResult Movies()
        {

            // in-memory list of movie objects
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "2001: A Space Odyssey", Genre = "Sci-Fi", ReleaseYear = 1968, IsFeatured = false, IsClassic = true },
                new Movie { Id = 2, Title = "Blade Runner 2049", Genre = "Sci-Fi", ReleaseYear = 2017, IsFeatured = true, IsClassic = false },
                new Movie { Id = 3, Title = "The Princess Bride", Genre = "Fantasy", ReleaseYear = 1987, IsFeatured = false, IsClassic = true },
                new Movie { Id = 4, Title = "The Matrix", Genre = "Thriller", ReleaseYear = 1999, IsFeatured = false, IsClassic = false },
                new Movie { Id = 5, Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014, IsFeatured = true, IsClassic = false },
                new Movie { Id = 6, Title = "Gladiator", Genre = "Action", ReleaseYear = 2000, IsFeatured = false, IsClassic = false },
                new Movie { Id = 7, Title = "The Godfather Part II", Genre = "Drama", ReleaseYear = 1974, IsFeatured = false, IsClassic = true },
                new Movie { Id = 8, Title = "Pan's Labyrinth", Genre = "Fantasy", ReleaseYear = 2006, IsFeatured = true, IsClassic = false },
                new Movie { Id = 9, Title = "Psycho", Genre = "Horror", ReleaseYear = 1960, IsFeatured = false, IsClassic = true },
                new Movie { Id = 10, Title = "District 9", Genre = "Sci-Fi", ReleaseYear = 2009, IsFeatured = false, IsClassic = false },
                new Movie { Id = 11, Title = "A Knight's Tale", Genre = "Fantasy", ReleaseYear = 2001, IsFeatured = false, IsClassic = false },
                new Movie { Id = 12, Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015, IsFeatured = true, IsClassic = false },
            };

            // viewdata & viewbag pass small page bits of metadata to the view
            ViewData["Title"] = "CineMini Movie Listings"; // page title (string)
            ViewData["LastUpdated"] = DateTime.Now.ToShortDateString(); // date
            ViewBag.TotalMovies = movies.Count; // dynamic property, operations resolved at runtime

            // passes the full list to the view
            // makes the view a strongly typed view
            return View(movies);
        }
    }
}