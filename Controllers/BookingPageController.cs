using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docter_MVC_Miniproject3.Models;
using Docter_MVC_Miniproject3.Views.ViewModels;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Mvc;


namespace Docter_MVC_Miniproject3.Controllers
{
    public class BookingPageController : Controller
    {


        private readonly IAppointmentRepository _appointmentRepository ;
        private readonly BookingPage _bookingPage;

        public BookingPageController(IAppointmentRepository appointmentRepository, BookingPage bookingPage)
        {
            _appointmentRepository = appointmentRepository;
            _bookingPage = bookingPage;
        }

        [HttpGet]
        public ViewResult Index()
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



         public RedirectToActionResult AddToBookingPage(int appointmentId)
        { 

            var selectedAppointment = _appointmentRepository.AllAppointments.FirstOrDefault(a => a.AppointmentId == appointmentId);

            if (selectedAppointment != null)
            {
                _bookingPage.AddToBookingPage(selectedAppointment, 1);
               
            }
            
            return RedirectToAction("Index");
        }

    }
}
