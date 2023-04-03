using Microsoft.EntityFrameworkCore;
using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async void AddActor(Actor actor)
        {
            var result = await _context.Actors.AddAsync(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActor(Actor actor)
        {
            var result = await _context.Actors.FindAsync(actor);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(string id, Actor newActor)
        {
            throw new NotImplementedException();
        }

        Task<Actor> IActorsService.GetActor(string id)
        {
            throw new NotImplementedException();
        }
    }
}
