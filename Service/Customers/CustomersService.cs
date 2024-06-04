using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using VidP.Data;
using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Customers
{
    public class CustomersService : ICustomersService
    {

        private readonly BaseContext _context;

        public CustomersService(BaseContext context)
        {
            _context = context;
        }

        public async Task<Customer> CreateCustomerAsync(CustomerDTO customerDTO)
        {
            var customer = new Customer()
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                Address = customerDTO.Address,
                Status = customerDTO.Status,
            };
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> EditCustomerAsync(CustomerDTO customerDTO)
        {
            var customer = new Customer()
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                Address = customerDTO.Address,
                Status = customerDTO.Status,
            };
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomersByStatusAsync(string status)
        {
            return await _context.Customers.Where(d => d.Status == status).ToListAsync();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
    }
}