using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;
using CarReservationAPI.Requests;

namespace CarReservationAPI.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<Car> FindAsync(DateTime startTime, DateTime endTime)
        {
            return await _carRepository.FindAsync(startTime, endTime);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _carRepository.GetAllAsync();
        }

        public async Task<Car> AddAsync(PostCarRequest postCarRequest)
        {
            var car = new Car(postCarRequest.Make, postCarRequest.Model, postCarRequest.Reservations);
            return await _carRepository.AddAsync(car);
        }

        public async Task<Car> UpdateAsync(UpdateCarRequest updateCarRequest)
        {
            var car = new Car(updateCarRequest.Make, updateCarRequest.Model, updateCarRequest.Reservations);
            return await _carRepository.UpdateAsync(car);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _carRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Car>> GetAllAsyncFindAsync(DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }
    }
}
