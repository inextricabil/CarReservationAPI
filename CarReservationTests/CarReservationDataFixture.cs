using CarReservationAPI;
using CarReservationAPI.Domain;

namespace CarReservationTests
{
    public class CarReservationSeedDataFixture : IDisposable
    {
        public ApiContext CarReservationContext { get; private set; } = new ApiContext();

        public CarReservationSeedDataFixture()
        {
            var cars = new List<Car>() {
                new Car("Mercedes-Benz", "GLC"),
                new Car("Volkswagen", "Arteon"),
                new Car("Ford", "Mustang"),
                new Car("Porsche", "911"),
                new Car("Jaguar", "F-PACE")
            };

            var reservation = new Reservation { Car = cars.First(), StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2) };

            CarReservationContext.Cars.AddRange(cars);
            CarReservationContext.Reservations.Add(reservation);
            CarReservationContext.SaveChanges();
        }

        public void Dispose()
        {
            CarReservationContext.Dispose();
            //GC.SuppressFinalize(this);
        }
    }
}
