using System;
using System.Linq;
using VidP.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Movies;
using System.Collections.Generic;
using VidP.DTOs;

namespace VidP.Controllers.Movies
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateMovieController : ControllerBase
    {
        private readonly IMoviesService _MoviesService;

        public CreateMovieController(IMoviesService MoviesService)
        {
            _MoviesService = MoviesService;
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> CreateMovie([FromBody] MovieDTO movie)
        {
            Movie result = await _MoviesService.CreateMovieAsync(movie);
            return Ok(result);
        }
    }
}