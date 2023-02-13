using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;
using System.Linq.Expressions;

namespace CarReservationAPI.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApiContext context) : base(context)
        {
        }

        public async Task<Car> Getsync(DateTime startDate, DateTime endDate)
        {
            //var predicate = (Reservation r) => startDate > r.EndTime || (startDate < r.StartTime && endDate < r.StartTime);
            Expression<Func<Reservation, bool>> genericMap = Expression<Reservation, Car>(r => r.StartDate == startDate && r.EndDate == endDate);
            var result = await FindAsync(predicate);


            return null;
            //await Context.SaveChangesAsync();
            //var updatedCar = await GetAsync(car.Id);
            //return updatedCar;
        }
    }
}
