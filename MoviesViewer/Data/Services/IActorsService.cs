using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetActors();
        Task<Actor> GetActor(Actor id);
        Task<Actor> GetActor(string id);
        void AddActor(Actor actor);
        Actor UpdateActor(string id, Actor newActor);
        void DeleteActor(string id);

    }
}
