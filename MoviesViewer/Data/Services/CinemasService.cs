using Microsoft.EntityFrameworkCore;
using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    /// <summary>
    /// Cinmeas Service is used for the db communication for retrieving cinemas objects
    /// </summary>
    public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context)
        {
            _context = context;
        }
        public async void AddCinema(Cinema cinema)
        {
            var result = await _context.Cinemas.AddAsync(cinema);
           _= await _context.SaveChangesAsync();
        }
        public void DeleteCinema(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public async Task<Cinema> GetCinema(Cinema cinema)
        {
            var result = await _context.Cinemas.FindAsync(cinema);
            return result;
        }

        public async Task<Cinema> GetCinemaById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetCinemas()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public Cinema UpdateCinema(string id, Cinema cinema)
        {
            throw new NotImplementedException();
        }
    }
}
