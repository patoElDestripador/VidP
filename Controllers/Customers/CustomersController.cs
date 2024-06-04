using VidP.Model;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Customers;
using Microsoft.EntityFrameworkCore;

namespace VidP.Controllers.Customers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _CustomersService;

        public CustomersController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomerById(int id)
        {
            Customer result = await _CustomersService.GetCustomerByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAllCustomers()
        {
            IEnumerable<Customer> result = await _CustomersService.GetAllCustomersAsync();
            return Ok(result);
        }

        [HttpGet("Status/{status}")]
        public async Task<ActionResult> GetAllCustomers(string status)
        {
            IEnumerable<Customer> result = await _CustomersService.GetCustomersByStatusAsync(status);
            return Ok(result);
        }
    }
}