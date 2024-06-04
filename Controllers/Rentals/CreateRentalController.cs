using System;
using System.Linq;
using VidP.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Rentals;
using System.Collections.Generic;
using VidP.DTOs;

namespace VidP.Controllers.Rentals
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateRentalController : ControllerBase
    {
        private readonly IRentalsService _RentalsService;

        public CreateRentalController(IRentalsService RentalsService)
        {
            _RentalsService = RentalsService;
        }

        [HttpPost]
        public async Task<ActionResult<Rental>> CreateRental([FromBody] RentalDTO rental)
        {
            Rental result = await _RentalsService.CreateRentalAsync(rental);
            return Ok(result);
        }
    }
}