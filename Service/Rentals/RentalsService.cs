using Microsoft.EntityFrameworkCore;
using VidP.Data;
using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Rentals
{
    public class RentalsService : IRentalsService
    {

        private readonly BaseContext _context;

        public RentalsService(BaseContext context)
        {
            _context = context;
        }

        public async Task<Rental> CreateRentalAsync(RentalDTO rentalDTO)
        {
            var rental = new Rental()
            {
                CustomerId = rentalDTO.CustomerId,
                MovieId = rentalDTO.MovieId,
                RentalDate = rentalDTO.RentalDate,
                ReturnDate = rentalDTO.ReturnDate,
                EmployeeId = rentalDTO.EmployeeId,
                Status = rentalDTO.Status,
            };
            await _context.Rentals.AddAsync(rental);
            await _context.SaveChangesAsync();
            return rental;
        }

        public async Task<Rental> EditRentalAsync(RentalDTO rentalDTO)
        {
            var rental = new Rental()
            {
                Id = rentalDTO.Id ?? 0,
                CustomerId = rentalDTO.CustomerId,
                MovieId = rentalDTO.MovieId,
                RentalDate = rentalDTO.RentalDate,
                ReturnDate = rentalDTO.ReturnDate,
                EmployeeId = rentalDTO.EmployeeId,
                Status = rentalDTO.Status,
            };
            _context.Entry(rental).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return rental;
        }

        public async Task<IEnumerable<Rental>> GetAllRentalsAsync()
        {
            return await _context.Rentals.Include(e => e.Customer).Include(e => e.Movie).Include(e => e.Employee).ToListAsync();
        }

        public async Task<IEnumerable<Rental>> GetRentalsByStatusAsync(string status)
        {
            return await _context.Rentals.Include(e => e.Customer).Include(e => e.Movie).Include(e => e.Employee).Where(d => d.Status == status).ToListAsync();
        }

        public Rental GetRentalById(int id)
        {
            return _context.Rentals.Find(id);
        }

        public async Task<Rental> GetRentalByIdAsync(int id)
        {
            return await _context.Rentals.Include(e => e.Customer).Include(e => e.Movie).Include(e => e.Employee).FirstOrDefaultAsync(d => d.Id == id);
        }

        public Task<Rental> DeleteRentalAsync(RentalDTO RentalDTO)
        {
            throw new NotImplementedException();
        }
    }
}