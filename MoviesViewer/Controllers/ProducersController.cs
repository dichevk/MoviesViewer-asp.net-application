using MoviesViewer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MoviesViewer.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProducersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Producer()
        {
            var producers = await _appDbContext.Producers.ToListAsync();
            return View(producers);
        }
    }
}
