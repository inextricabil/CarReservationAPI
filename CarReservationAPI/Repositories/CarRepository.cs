using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;
using System.Linq.Expressions;

namespace CarReservationAPI.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(ApiContext context) : base(context)
        {
        }

        public async Task<Car> AddAsync(Car car)
        {
            Add(car);
            await Context.SaveChangesAsync();
            car = await GetAsync(car.Id);
            return car;
        }

        public async Task<Car> UpdateAsync(Car car)
        {
            Update(car);
            await Context.SaveChangesAsync();
            var updatedCar = await GetAsync(car.Id);
            return updatedCar;
        }

        public async Task<Car> FindAsync(DateTime startDate, DateTime endDate)
        {
            return null;
            //WIP
            //var result = await FindAsync(predicate);
            //await Context.SaveChangesAsync();
            //var updatedCar = await GetAsync(car.Id);
            //return updatedCar;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var carToBeRemoved = await GetAsync(id);
            if (carToBeRemoved != null)
            {
                Remove(carToBeRemoved);
                await Context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        //private async Task<int> GetNextIdAsync()
        //{
        //    var cars = await GetAllAsync();
        //    return cars.Max(car => car.Id) + 1;
        //}
    }
}
