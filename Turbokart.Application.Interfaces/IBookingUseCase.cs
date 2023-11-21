using Turbokart.Domain.Entities;

namespace Turbokart.Application.Interfaces
{
    public interface IBookingUseCase
    {
        void BookNew(Booking booking, Customer customer);
        IEnumerable<Booking> GetAllBookings();
        IEnumerable<Booking> GetTodaysBookings();
    }
}