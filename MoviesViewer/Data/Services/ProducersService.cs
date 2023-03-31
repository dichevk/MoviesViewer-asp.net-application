using Microsoft.EntityFrameworkCore;
using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context)
        {
            _context = context;
        }
        public void AddProducer(Producer producer)
        {
            throw new NotImplementedException();
        }

        public void DeleteProducer(Producer producer)
        {
            throw new NotImplementedException();
        }

        public async Task<Producer> GetProducer(Producer producer)
        {
            var result = await _context.Producers.FindAsync(producer);
            return result; 
        }

        public Task<Producer> GetProducerById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetProducers()
        {
            var result = await _context.Producers.ToListAsync();
            return result; 
        }

        public Producer UpdateProducer(string id, Producer producer)
        {
            throw new NotImplementedException();
        }
    }
}
