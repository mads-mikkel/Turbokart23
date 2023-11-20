using Turbokart.Domain.Entities;

namespace Turbokart.Application.Interfaces
{
    public interface IBookingUseCase
    {
        void BookNew(DateTime dateTime, Customer customer);
        IEnumerable<Booking> GetAllBookings();
        IEnumerable<Booking> GetTodaysBookings();
    }
}