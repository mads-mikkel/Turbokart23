namespace Turbokart.Infrastructure.Persistence.Interfaces
{
    public interface IUnitOFWork: IDisposable
    {
        void Commit();
        void RollBack();
        IBookingRepository BookingRepository { get; }
        ICustomerRepository CustomerRepository { get; }
    }
}