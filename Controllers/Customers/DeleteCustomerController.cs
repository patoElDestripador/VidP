using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Services.Customers;

namespace NombreDelProyecto.Controllers.Customers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteCustomerController : ControllerBase
    {
        private readonly ICustomersService _CustomersService;

        public DeleteCustomerController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            //Customer result = await _CustomersService.DeleteCustomerAsync(id);
            return Ok();
        }
    }
}