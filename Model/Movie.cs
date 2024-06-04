using System.Text.Json.Serialization;

namespace VidP.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int CategoryId { get; set; }
        public string Availability { get; set; }
        public int AmountOfMovies { get; set; }

        public Category Category { get; set; }
        [JsonIgnore]
        public List<Rental> Rentals { get; set; }
    }

}