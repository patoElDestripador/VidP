using System.ComponentModel.DataAnnotations;

namespace VidP.DTOs
{
    public class CategoryDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "El campo CategoryName es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo CategoryName no puede tener más de 50 caracteres.")]
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
