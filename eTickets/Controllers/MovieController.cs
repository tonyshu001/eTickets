using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var AllMovies = await _service.GetAllAsync(n => n.Cinema);

            return View(AllMovies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var AllMovies = await _service.GetAllAsync(n => n.Cinema);
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = AllMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) 
                || n.Description.ToLower().Contains(searchString.ToLower())).ToList();
                return View("Index", filteredResult);
            }
            return View("Index", AllMovies);
        }

        //Get: Movie/Details/id
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //Get: Movie/Create
        public async Task<IActionResult> Create()
        {
            var movieDropDownsData = await _service.GetNewMovieDropDownsValues();
            ViewBag.Cinemas = new SelectList(movieDropDownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropDownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropDownsData.Actors, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM newMovieVM)
        {
            if (!ModelState.IsValid)
            {
                var movieDropDownsData = await _service.GetNewMovieDropDownsValues();
                ViewBag.Cinemas = new SelectList(movieDropDownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropDownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropDownsData.Actors, "Id", "FullName");
                return View(newMovieVM);
            }

            await _service.AddNewMovieAsync(newMovieVM);
            return RedirectToAction(nameof(Index));
        }

        //Get: Movie/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            if (movieDetails == null) 
            {
                return View("NotFound");
            }
            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.MovieCategory,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                ActorIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList()
            };

            var movieDropDownsData = await _service.GetNewMovieDropDownsValues();
            ViewBag.Cinemas = new SelectList(movieDropDownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropDownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropDownsData.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM newMovieVM)
        {
            if (id != newMovieVM.Id)
            {
                return View("NotFound");
            }

            if (!ModelState.IsValid)
            {
                var movieDropDownsData = await _service.GetNewMovieDropDownsValues();
                ViewBag.Cinemas = new SelectList(movieDropDownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropDownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropDownsData.Actors, "Id", "FullName");
                return View(newMovieVM);
            }

            await _service.UpdateMovieAsync(newMovieVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
