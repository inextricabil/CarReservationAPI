using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;

namespace CarReservationAPI.Responses
{
    public class PostCarResponse : IResponse
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CustomId => "C<" + Id + ">";
        public ICollection<Reservation> Reservations { get; set; }
    }
}
