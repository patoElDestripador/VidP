using VidP.DTOs;
using VidP.Model;

namespace VidP.Services.Rentals
{
    public interface IRentalsService
    {
        Task<Rental> CreateRentalAsync(RentalDTO RentalDTO);
        Task<Rental> EditRentalAsync(RentalDTO RentalDTO);
        Task<Rental> DeleteRentalAsync(RentalDTO RentalDTO);
        Task<IEnumerable<Rental>> GetAllRentalsAsync();
        Task<IEnumerable<Rental>> GetRentalsByStatusAsync(string status);
        Task<Rental> GetRentalByIdAsync(int id);
    }
}