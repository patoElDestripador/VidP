using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Movies
{
    public interface IMoviesService
    {
        Task<Movie> CreateMovieAsync(MovieDTO MovieDTO);
        Task<Movie> EditMovieAsync(MovieDTO MovieDTO);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<IEnumerable<Movie>> GetMoviesByStatusAsync(string status);
        Task<Movie> GetMovieByIdAsync(int id);
    }
}