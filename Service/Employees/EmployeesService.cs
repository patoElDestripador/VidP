using Microsoft.EntityFrameworkCore;
using VidP.Data;
using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Employees
{
    public class EmployeesService : IEmployeesService
    {

        private readonly BaseContext _context;

        public EmployeesService(BaseContext context)
        {
            _context = context;
        }

        public async Task<Employee> CreateEmployeeAsync(EmployeeDTO employeeDTO)
        {
            var employee = new Employee()
            {
                FirstName = employeeDTO.FirstName,
                LastName = employeeDTO.LastName,
                Email = employeeDTO.Email,
                Phone = employeeDTO.Phone,
                Status = employeeDTO.Status,
                HireDate = employeeDTO.HireDate,
            };
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> EditEmployeeAsync(EmployeeDTO employeeDTO)
        {
            var employee = new Employee()
            {
                Id = employeeDTO.Id ?? 0,
                FirstName = employeeDTO.FirstName,
                LastName = employeeDTO.LastName,
                Email = employeeDTO.Email,
                Phone = employeeDTO.Phone,
                Status = employeeDTO.Status,
                HireDate = employeeDTO.HireDate,
            };
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByStatusAsync(string status)
        {
            return await _context.Employees.Where(d => d.Status == status).ToListAsync();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
    }
}