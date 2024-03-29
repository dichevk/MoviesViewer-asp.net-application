﻿using MoviesViewer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MoviesViewer.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public MoviesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    
        public async Task<IActionResult> Index()
        {
            var movies = await _appDbContext.Movies
                .Include(x => x.Cinema)
                .OrderBy(x => x.StartDate)
                .ToListAsync();
            return View(movies);
        }
    }
}
