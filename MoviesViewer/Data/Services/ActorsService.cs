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
        public void AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void DeleteActor(string id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActor(string id)
        {
            throw new NotImplementedException();
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
    }
}
