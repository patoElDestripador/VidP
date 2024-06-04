using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Employees
{
    public interface IEmployeesService
    {
        Task<Employee> CreateEmployeeAsync(EmployeeDTO EmployeeDTO);
        Task<Employee> EditEmployeeAsync(EmployeeDTO EmployeeDTO);
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<IEnumerable<Employee>> GetEmployeesByStatusAsync(string status);
        Task<Employee> GetEmployeeByIdAsync(int id);
    }
}