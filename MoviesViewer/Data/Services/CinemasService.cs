using Microsoft.EntityFrameworkCore;
using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context)
        {
            _context = context;
        }
        public void AddCinema(Cinema cinema)
        {
            throw new NotImplementedException();
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
        public async Task<IEnumerable<Cinema>> GetCinemas()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }
    }
}
