using CarReservationAPI.Domain;
namespace CarReservationAPI.Interfaces
{
    public interface ICarReservationService
    {
        Task<IEnumerable<Car>> FindAvailableCar(DateTime time, TimeSpan duration);
        Task<Reservation> StoreReservation(DateTime time, TimeSpan duration, string carId);
    }
}
