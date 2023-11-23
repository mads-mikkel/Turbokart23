using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

using Turbokart.Application.Interfaces;
using Turbokart.Domain.Entities;

namespace Turbokart.Presenter.Websites.TurbokartDK.Pages
{
    public class BookingModel: PageModel
    {
        private readonly IBookingUseCase bookingUseCase;

        public BookingModel(IBookingUseCase bookingUseCase)
        {
            this.bookingUseCase = bookingUseCase;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string PhoneNumber { get; set; }

        [BindProperty]
        public DateTime Date { get; set; } = DateTime.Today;

        [BindProperty]
        public string Time { get; set; }

        [BindProperty]
        public int Number { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var email = Email;
            var phone = PhoneNumber;
            var d = Date;
            var t = Time;
            var n = Number;

            Booking b = new Booking() { BookingId = 0, CustomerId = 0, Start = Date };
            bookingUseCase.BookNew(b);

            // send booking til API
            return Redirect("/Index");
        }
    }
}
