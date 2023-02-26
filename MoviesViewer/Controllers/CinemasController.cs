using MoviesViewer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MoviesViewer.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CinemasController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    
        public async Task<IActionResult> Index()
        {
            var cinemas = await _appDbContext.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
