using System;
using Docter_MVC_Miniproject3.Models;
using Docter_MVC_Miniproject3.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Docter_MVC_Miniproject3.Components
{
    public class BookingPageSummary : ViewComponent
    {
        private readonly BookingPage _bookingPage;

        public BookingPageSummary(BookingPage bookingPage)
        {
            _bookingPage = bookingPage;
        }


        public IViewComponentResult Invoke()
        {
            var items = _bookingPage.GetBookingPageItems();
            _bookingPage.BookingPageItems = items;

            var bookingPageViewModel = new BookingPageViewModel
            {
                BookingPage = _bookingPage
                // BookingPageTotal = _bookingPage.GetShoppingCartTotal()
            };

            return View(bookingPageViewModel);
        }
    }
}
