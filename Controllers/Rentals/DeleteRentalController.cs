using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Services.Rentals;

namespace NombreDelProyecto.Controllers.Rentals
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteRentalController : ControllerBase
    {
        private readonly IRentalsService _RentalsService;

        public DeleteRentalController(IRentalsService RentalsService)
        {
            _RentalsService = RentalsService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRental(int id)
        {
           // ResponseUtils<Rental> result = await _RentalsService.DeleteRentalAsync(id);
            return Ok();
        }
    }
}