using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidP.DTOs
{
    public class CustomerDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "El campo FirstName es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo FirstName no puede tener más de 50 caracteres.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El campo LastName es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo LastName no puede tener más de 50 caracteres.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no es válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo Phone es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Phone no puede tener más de 20 caracteres.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "El campo Address es obligatorio.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "El campo Status no es válido.")]
        [StringLength(50, ErrorMessage = "El campo Status no puede tener más de 50 caracteres.")]
        public string Status { get; set; }
        [Required(ErrorMessage = "La fecha de registro es obligatoria.")]
        public DateTime RegistrationDate { get; set; }
    }
}
