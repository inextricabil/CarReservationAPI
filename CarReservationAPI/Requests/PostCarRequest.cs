using CarReservationAPI.Domain;

namespace CarReservationAPI.Requests
{
    public class PostCarRequest
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
