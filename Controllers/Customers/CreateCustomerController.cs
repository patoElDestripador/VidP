using System;
using System.Linq;
using VidP.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Customers;
using System.Collections.Generic;
using VidP.DTOs;

namespace VidP.Controllers.Customers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateCustomerController : ControllerBase
    {
        private readonly ICustomersService _CustomersService;

        public CreateCustomerController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer([FromBody] CustomerDTO customer)
        {
            Customer result = await _CustomersService.CreateCustomerAsync(customer);
            return Ok(result);
        }
    }
}