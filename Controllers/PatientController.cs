using System;
using System.Collections.Generic;
using System.Linq;
using Docter_MVC_Miniproject3.Data;
using Docter_MVC_Miniproject3.Models;
using Docter_MVC_Miniproject3.Views.ViewModels;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Docter_MVC_Miniproject3.Controllers
{
    [Authorize]
    public class PatientController: Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly BookingPage _bookingPage;
        private readonly IPatientRepository _patientRepository;
       



        public PatientController( BookingPage bookingPage, IPatientRepository patientRepository, ApplicationDbContext applicationDbContext)
        {
        
            _bookingPage = bookingPage;
            _patientRepository = patientRepository;
            _applicationDbContext = applicationDbContext;
           
        }

        public IActionResult Checkout()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CheckOut(Patient patient)
        {

            var items = _bookingPage.GetBookingPageItems();
            _bookingPage.BookingPageItems = items;
          

            if (_bookingPage.BookingPageItems.Count == 0)
            {
                ModelState.AddModelError("", "No Appointments selected");
            }

            if (ModelState.IsValid)
            {
                _patientRepository.CreatePatient(patient);
                _bookingPage.ClearBookingPage();

                // return RedirectToAction("CheckOut");
            return RedirectToAction("Details", "Patient", new { ID = patient.PatientId });

            }
            return View(patient);

        }

        public IActionResult Details(int ID)
        { 
            var list = _applicationDbContext.PatientDetails.Where(c => c.PatientId == ID).Include(c => c.Appointment).Include(c => c.Patient).ToList();
            PatientViewModel patientViewModel = new PatientViewModel();
            patientViewModel.PatientDetails = list;

            return View(patientViewModel);
        }

        //[HttpGet]
        //public ViewResult Index()
        //{
        //    var items = _patient1.PatientDetails;


        //    PatientViewModel patientViewModel = new PatientViewModel();
        //    patientViewModel.appointments = (IEnumerable<Appointment>)items;

        //    return View(patientViewModel);
        //}


    }
}
