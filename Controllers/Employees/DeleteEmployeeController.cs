using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Model;
using VidP.Services.Employees;

namespace NombreDelProyecto.Controllers.Employees
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteEmployeeController : ControllerBase
    {
        private readonly IEmployeesService _EmployeesService;

        public DeleteEmployeeController(IEmployeesService EmployeesService)
        {
            _EmployeesService = EmployeesService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
           // Employee result = await _EmployeesService.DeleteEmployeeAsync(id);
            return Ok();
        }
    }
}