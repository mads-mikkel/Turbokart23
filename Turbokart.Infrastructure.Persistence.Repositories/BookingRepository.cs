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
            return set.Include(b => b.Customer)
                .Where(b => b.Start.Date == DateTime.Today).ToList();
        }

        public override IEnumerable<Booking> GetAll()
        {
            return set.Include(b => b.Customer);
        }
    }
}
