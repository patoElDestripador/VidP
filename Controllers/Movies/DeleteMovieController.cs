using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Model;
using VidP.Services.Movies;

namespace NombreDelProyecto.Controllers.Movies
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteMovieController : ControllerBase
    {
        private readonly IMoviesService _MoviesService;

        public DeleteMovieController(IMoviesService MoviesService)
        {
            _MoviesService = MoviesService;
        }

        [HttpDelete("{id}")]
        public ActionResult FDeleteMovie(int id)
        {
            // _MoviesService.DeleteMovie(id);
            return Ok();
        }
    }
}