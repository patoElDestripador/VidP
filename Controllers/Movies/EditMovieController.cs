using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Services.Movies;
using VidP.Model;
using VidP.DTOs;

namespace NombreDelProyecto.Controllers.Movies
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditMovieController : ControllerBase
    {
        private readonly IMoviesService _MoviesService;

        public EditMovieController(IMoviesService MoviesService)
        {
            _MoviesService = MoviesService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> EditMovie(int id, [FromBody] MovieDTO movie)
        {
            return Ok(await _MoviesService.EditMovieAsync(movie));
        }
    }
}