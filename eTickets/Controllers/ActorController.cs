using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _Service;

        public ActorController(IActorService service)
        {
            _Service = service;
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _Service.GetAll();
            return View(Data);
        }

        //Get request: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            
            _Service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
