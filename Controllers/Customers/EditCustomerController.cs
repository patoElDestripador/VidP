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
    public class EditCustomerController : ControllerBase
    {
        private readonly ICustomersService _CustomersService;

        public EditCustomerController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> EditCustomer( [FromBody] CustomerDTO customer)
        {
            return Ok(await _CustomersService.EditCustomerAsync(customer));
        }
    }
}