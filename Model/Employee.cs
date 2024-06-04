using System.Text.Json.Serialization;

namespace VidP.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public DateTime HireDate { get; set; }

        [JsonIgnore]
        public List<Rental> Rentals { get; set; }
    }
}