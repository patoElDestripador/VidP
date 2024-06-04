using Microsoft.EntityFrameworkCore;
using VidP.Data;
using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Movies
{
    public class MoviesService : IMoviesService
    {

        private readonly BaseContext _context;

        public MoviesService(BaseContext context)
        {
            _context = context;
        }

        public async Task<Movie> CreateMovieAsync(MovieDTO movieDTO)
        {
            var movie = new Movie()
            {
                Title = movieDTO.Title,
                Description = movieDTO.Description,
                ReleaseYear = movieDTO.ReleaseYear,
                CategoryId = movieDTO.CategoryId,
                Availability = movieDTO.Availability,
                AmountOfMovies = movieDTO.AmountOfMovies,
            };
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> EditMovieAsync(MovieDTO movieDTO)
        {
            var movie = new Movie()
            {
                Id = movieDTO.Id ?? 0,
                Title = movieDTO.Title,
                Description = movieDTO.Description,
                ReleaseYear = movieDTO.ReleaseYear,
                CategoryId = movieDTO.CategoryId,
                Availability = movieDTO.Availability,
                AmountOfMovies = movieDTO.AmountOfMovies,
            };
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.Include(e => e.Category).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesByStatusAsync(string status)
        {
            return await _context.Movies.Where(d => d.Availability == status).ToListAsync();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.Find(id);
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }
    }
}