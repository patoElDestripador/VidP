using System;
using System.Linq;
using VidP.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Employees;
using System.Collections.Generic;
using VidP.DTOs;

namespace VidP.Controllers.Employees
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateEmployeeController : ControllerBase
    {
        private readonly IEmployeesService _EmployeesService;

        public CreateEmployeeController(IEmployeesService EmployeesService)
        {
            _EmployeesService = EmployeesService;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee([FromBody] EmployeeDTO employee)
        {
            Employee result = await _EmployeesService.CreateEmployeeAsync(employee);
            return Ok(result);
        }
    }
}