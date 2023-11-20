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
            Booking booking = new Booking() { Start = dateTime, Customer = customer};

            if(customer.CustomerId == 0)    // handle new customer that does not exist in the DB.
            {
                ICustomerRepository customerRepository = unitOfWork.CustomerRepository;
                customerRepository.Save(customer);
            }

            IBookingRepository bookingRepository = unitOfWork.BookingRepository;
            bookingRepository.Save(booking);

            unitOfWork.Commit();
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            IBookingRepository bookingRepository = unitOfWork.BookingRepository;
            return bookingRepository.GetAll();
        }

        public IEnumerable<Booking> GetTodaysBookings()
        {
            throw new NotImplementedException();
        }
    }
}