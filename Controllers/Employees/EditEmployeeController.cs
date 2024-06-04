using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VidP.Model;
using VidP.DTOs;
using VidP.Services.Employees;

namespace NombreDelProyecto.Controllers.Employees
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditEmployeeController : ControllerBase
    {
        private readonly IEmployeesService _EmployeesService;

        public EditEmployeeController(IEmployeesService EmployeesService)
        {
            _EmployeesService = EmployeesService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> EditEmployee(int id, [FromBody] EmployeeDTO employee)
        {
            return Ok(await _EmployeesService.EditEmployeeAsync(employee));
        }
    }
}