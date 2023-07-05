using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _Context;

        public CinemaController(AppDbContext context)
        {
            _Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllCinemas = await _Context.Cinemas.ToListAsync();
            return View();
        }
    }
}
