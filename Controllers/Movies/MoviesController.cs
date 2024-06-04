using VidP.Model;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Movies;
using Microsoft.EntityFrameworkCore;

namespace VidP.Controllers.Movies
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _MoviesService;

        public MoviesController(IMoviesService MoviesService)
        {
            _MoviesService = MoviesService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            Movie result = await _MoviesService.GetMovieByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            IEnumerable<Movie> result = await _MoviesService.GetAllMoviesAsync();
            return Ok(result);
        }

        [HttpGet("Status/{status}")]
        public async Task<IActionResult> GetAllMovies(string status)
        {
            IEnumerable<Movie> result = await _MoviesService.GetMoviesByStatusAsync(status);
            return Ok(result);
        }
    }
}