using Turbokart.Domain.Entities;

namespace Turbokart.Application.Interfaces
{
    public interface IBookingUseCase
    {
        void BookNew(Booking booking);
        IEnumerable<Booking> GetAllBookings();
        IEnumerable<Booking> GetTodaysBookings();
    }
}