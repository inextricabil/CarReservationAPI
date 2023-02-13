using CarReservationAPI.Domain;

namespace CarReservationAPI.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CustomId => "C<" + Id + ">";
        public ICollection<Reservation> Reservations { get; set; }
    }
}
