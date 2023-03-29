using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _appDbContext;

        public MoviesService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddMovie(Movie Movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(string id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(string id, Movie newMovie)
        {
            throw new NotImplementedException();
        }
    }

}
