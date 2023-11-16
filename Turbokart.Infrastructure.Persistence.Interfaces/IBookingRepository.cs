using Turbokart.Domain.Entities;

namespace Turbokart.Infrastructure.Persistence.Interfaces
{
    public interface IBookingRepository: IRepository<Booking>
    {
        IEnumerable<Booking> GetTodaysBookings();
    }
}