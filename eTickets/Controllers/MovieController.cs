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

        public async IActionResult Index()
        {
            var AllMovies = await _Context.Movies.ToListAsync();
            return View();
        }
    }
}
