using MoviesViewer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesViewer.Data.Services;

namespace MoviesViewer.Controllers
{
    public class ActorsController : Controller
    {
        //reference the AppDbContext file to be able to work with the data from the db
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Actors()
        {
            var data = await _service.GetActors();
            return View(data);
        }
        //GET Actors/Create 
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
