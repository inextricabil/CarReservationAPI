using CarReservationAPI.Domain;
using CarReservationAPI.Requests;

namespace CarReservationAPI.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllAsync(DateTime startTime, DateTime endTime);
        Task<IEnumerable<Car>> GetAllAsync();
        Task<Car> AddAsync(PostCarRequest postCarRequest);
        Task<Car> UpdateAsync(UpdateCarRequest updateCarRequest);
        Task<bool> DeleteAsync(int id);
    }
}
