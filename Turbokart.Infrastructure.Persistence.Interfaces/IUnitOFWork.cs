namespace Turbokart.Infrastructure.Persistence.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
        void RollBack();
        IBookingRepository BookingRepository { get; }
        ICustomerRepository CustomerRepository { get; }
    }
}