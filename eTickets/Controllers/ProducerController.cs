using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _Context;

        public ProducerController(AppDbContext context)
        {
            _Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var AllProducers = await _Context.Producers.ToListAsync();
            return View();
        }
    }
}
