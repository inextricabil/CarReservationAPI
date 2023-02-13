using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;

namespace CarReservationAPI.Responses
{
    public class GetCarsResponse : IResponse
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
