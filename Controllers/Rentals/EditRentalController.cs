using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Model;
using VidP.Services.Rentals;
using VidP.DTOs;

namespace NombreDelProyecto.Controllers.Rentals
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditRentalController : ControllerBase
    {
        private readonly IRentalsService _RentalsService;

        public EditRentalController(IRentalsService RentalsService)
        {
            _RentalsService = RentalsService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Rental>> EditRental(int id, [FromBody] RentalDTO rental)
        {
            return Ok(await _RentalsService.EditRentalAsync(rental));
        }
    }

}