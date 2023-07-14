using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;

        public ProducerController(IProducerService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var AllProducers = await _service.GetAllAsync();
            return View(AllProducers);
        }

        //Get: producer/details/id
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }
    }
}
