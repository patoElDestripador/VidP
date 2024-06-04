using VidP.Model;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Rentals;
using Microsoft.EntityFrameworkCore;

namespace VidP.Controllers.Rentals
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalsService _RentalsService;

        public RentalsController(IRentalsService RentalsService)
        {
            _RentalsService = RentalsService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRentalById(int id)
        {
            Rental result = await _RentalsService.GetRentalByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRentals()
        {
            IEnumerable<Rental> result = await _RentalsService.GetAllRentalsAsync();
            return Ok(result);
        }

        [HttpGet("Status/{status}")]
        public async Task<IActionResult> GetAllRentals(string status)
        {
            IEnumerable<Rental> result = await _RentalsService.GetRentalsByStatusAsync(status);
            return Ok(result);
        }
    }
}