using CarReservationAPI.Domain;
using CarReservationAPI.Requests;

namespace CarReservationAPI.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllAsync();
        Task<IEnumerable<Car>> FindAsync(DateTime startTime, DateTime endTime);
        Task<Car> AddAsync(PostCarRequest postCarRequest);
        Task<Car> UpdateAsync(UpdateCarRequest updateCarRequest);
        Task<bool> DeleteAsync(int id);
    }
}
