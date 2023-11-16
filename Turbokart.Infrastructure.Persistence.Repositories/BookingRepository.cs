using Microsoft.EntityFrameworkCore;

using Turbokart.Domain.Entities;
using Turbokart.Infrastructure.Persistence.Interfaces;

namespace Turbokart.Infrastructure.Persistence.Repositories
{
    public class BookingRepository: RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Booking> GetTodaysBookings()
        {
            return set.Where(b => b.Start.Date == DateTime.Today).ToList();
        }
    }
}
