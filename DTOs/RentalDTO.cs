using System.ComponentModel.DataAnnotations;

namespace VidP.DTOs
{
    public class RentalDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "El campo customerId es obligatorio.")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "El campo MovieId obligatorio.")]
        public int MovieId { get; set; }
        public DateTime? RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required(ErrorMessage = "El campo EmployeeId es obligatorio.")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "El campo Status es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Status no puede tener más de 50 caracteres.")]
        public string Status { get; set; }
    }
}
