using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VidP.DTOs
{
    public class MovieDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "El campo Title es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Title no puede tener más de 100 caracteres.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "El campo Description es obligatorio.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "El campo ReleaseYear es obligatorio.")]
        public DateTime ReleaseYear { get; set; }
        [Required(ErrorMessage = "El campo CategoryId es obligatorio.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "El campo Availability no es válido.")]
        [StringLength(50, ErrorMessage = "El campo Availability no puede tener más de 50 caracteres.")]
        public string Availability { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de películas debe ser mayor que cero.")]
        public int AmountOfMovies { get; set; }
    }
}
