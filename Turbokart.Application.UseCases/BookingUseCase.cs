using Turbokart.Application.Interfaces;
using Turbokart.Domain.Entities;
using Turbokart.Infrastructure.Persistence.Interfaces;

namespace Turbokart.Application.UseCases
{
    public class BookingUseCase: IBookingUseCase
    {
        private readonly IUnitOfWork unitOfWork;

        public BookingUseCase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void BookNew(DateTime dateTime, Customer customer)
        {
            Booking booking = new Booking() { Start = dateTime};


        }

        public IEnumerable<Booking> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetTodaysBookings()
        {
            throw new NotImplementedException();
        }
    }
}