using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public interface ICinemasService
    {
        Task<IEnumerable<Cinema>> GetCinemas();
        Task<Cinema>GetCinema(Cinema cinema);
        Task<Cinema> GetCinemaById(string id);
        void AddCinema(Cinema actor);
        Cinema UpdateCinema(string id, Cinema cinema);
        void DeleteCinema(Cinema cinema);
    }
}
