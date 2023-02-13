using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;
using CarReservationAPI.Repositories;

namespace CarReservationAPI.Services
{
    public class CarReservationService : ICarReservationService
    {
        /// <summary>
        /// The cars repository.
        /// </summary>
        public IRepository<Car> Cars { get; private set; }

        /// <summary>
        /// The reservations repository.
        /// </summary>
        public IRepository<Reservation> Reservations { get; private set; }

        public CarReservationService(ApiContext context)
        {
            Cars = new CarRepository(context);
            Reservations = new ReservationRepository(context);
        }

        public Task<Car> AddCarAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<Car> UpdateCarAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCarAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> FindAvailableCar(DateTime time, TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> StoreReservation(DateTime time, TimeSpan duration, string carId)
        {
            throw new NotImplementedException();
        }
    }
}
