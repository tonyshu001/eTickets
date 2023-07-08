using eTickets.Data;
using eTickets.Data.Services;
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
    }
}
