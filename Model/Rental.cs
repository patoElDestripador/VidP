namespace VidP.Model
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public DateTime? RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int EmployeeId { get; set; }
        public string Status { get; set; }

        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public Employee Employee { get; set; }
    }
}

//1 renta puede tener un empleado 

//pero un empleado puede terner muchas rentas