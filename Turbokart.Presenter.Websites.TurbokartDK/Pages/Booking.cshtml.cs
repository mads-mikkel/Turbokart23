using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

using Turbokart.Domain.Entities;

namespace Turbokart.Presenter.Websites.TurbokartDK.Pages
{
    public class BookingModel : PageModel
    {
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
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            // send booking til API
            return Redirect("/Index");
        }
    }
}
