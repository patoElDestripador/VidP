using VidP.Model;
using Microsoft.AspNetCore.Mvc;
using VidP.Services.Employees;
using Microsoft.EntityFrameworkCore;

namespace VidP.Controllers.Employees
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _EmployeesService;

        public EmployeesController(IEmployeesService EmployeesService)
        {
            _EmployeesService = EmployeesService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            Employee result = await _EmployeesService.GetEmployeeByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            IEnumerable<Employee> result = await _EmployeesService.GetAllEmployeesAsync();
            return Ok(result);
        }

        [HttpGet("Status/{status}")]
        public async Task<IActionResult> GetAllEmployees(string status)
        {
            IEnumerable<Employee> result = await _EmployeesService.GetEmployeesByStatusAsync(status);
            return Ok(result);
        }
    }
}