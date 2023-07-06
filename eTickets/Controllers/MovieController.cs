using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _Context;

        public MovieController(AppDbContext context)
        {
            _Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var AllMovies = await _Context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();

            return View(AllMovies);
        }
    }
}
