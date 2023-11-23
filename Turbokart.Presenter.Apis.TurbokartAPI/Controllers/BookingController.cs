using Microsoft.AspNetCore.Mvc;

using Turbokart.Application.Interfaces;
using Turbokart.Domain.Entities;

namespace Turbokart.Presenter.Apis.TurbokartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController: Controller
    {
        private readonly IBookingUseCase bookingUseCase;

        public BookingController(IBookingUseCase bookingUseCase)
        {
            this.bookingUseCase = bookingUseCase;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveNew(Booking booking)
        {
            try
            {
                bookingUseCase.BookNew(booking);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
