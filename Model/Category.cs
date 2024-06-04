using System.Text.Json.Serialization;

namespace VidP.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }

        [JsonIgnore]
        public List<Movie> Movies { get; set; }
    }

}


