using System.Net.Http.Json;

using Turbokart.Application.Interfaces;
using Turbokart.Domain.Entities;

namespace Turbokart.Infrastructure.Networking.Services
{
    public class BookingService: IBookingUseCase
    {
        string url = "http://localhost:5141";

        public async void BookNew(Booking booking)
        {
            using(HttpClient client = new())
            {
                client.BaseAddress = new Uri(url);
                var result = await Task.Run(() => client.PostAsJsonAsync("/api/Booking", booking));
            }
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
