using System.Text.Json.Serialization;

namespace VidP.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }

        [JsonIgnore]
        public List<Rental> Rentals { get; set; }
    }
}