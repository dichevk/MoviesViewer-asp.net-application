using Microsoft.EntityFrameworkCore;
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

        public async void AddMovie(Movie Movie)
        {
            var result = await _appDbContext.Movies.AddAsync(Movie);
            _ = await _appDbContext.SaveChangesAsync();

        }

        public void DeleteMovie(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie>GetMovie(Movie movie)
        {
            var result = await _appDbContext.Movies.FindAsync(movie);
            return result; 
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var result = await _appDbContext.Movies.ToListAsync();
            return result;
        }

        public Movie UpdateMovie(string id, Movie newMovie)
        {
            throw new NotImplementedException();
        }
    }

}
