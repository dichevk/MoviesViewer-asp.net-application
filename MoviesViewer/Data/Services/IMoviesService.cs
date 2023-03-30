using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetMovies();
        void AddMovie(Movie Movie);
        Movie UpdateMovie(string id, Movie newMovie);
        void DeleteMovie(string id);
        Task<Movie> GetMovie(Movie movie);
    }
}
