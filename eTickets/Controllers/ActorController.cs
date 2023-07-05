using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _Context;

        public ActorController(AppDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            var Data = _Context.Actors.ToList();
            return View();
        }
    }
}
