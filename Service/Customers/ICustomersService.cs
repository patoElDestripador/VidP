using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Customers
{
    public interface ICustomersService
    {
        Task<Customer> CreateCustomerAsync(CustomerDTO CustomerDTO);
        Task<Customer> EditCustomerAsync(CustomerDTO CustomerDTO);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<IEnumerable<Customer>> GetCustomersByStatusAsync(string status);
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}