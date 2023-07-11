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
            var Data = await _Service.GetAllAsync();
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
            
            await _Service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get request: Actor/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var ActorDetails = await _Service.GetByIdAsync(id);
            if(ActorDetails == null)
            {
                return View("NotFound");
            }
            return View(ActorDetails);
        }

        //Get request: Actor/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var ActorDetails = await _Service.GetByIdAsync(id);
            if(ActorDetails == null)
            {
                return View("NotFound");
            }
            return View(ActorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _Service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get request: Actor/delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var ActorDetails = await _Service.GetByIdAsync(id);
            if (ActorDetails == null)
            {
                return View("NotFound");
            }
            return View(ActorDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteComfirmed(int id)
        {
            var ActorDetails = await _Service.GetByIdAsync(id);
            if (ActorDetails == null)
            {
                return View("NotFound");
            }

            await _Service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
