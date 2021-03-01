
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Models
{
    public class PatientRepository:IPatientRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly BookingPage _bookingPage;


        public PatientRepository(ApplicationDbContext appDbContext, BookingPage bookingPage)
        {
            _appDbContext = appDbContext;
            _bookingPage = bookingPage;
        }

        public void CreatePatient(Patient patient)
        {
            patient.BookingTime = DateTime.Now;
            var BookingPageItems = _bookingPage.BookingPageItems;

            patient.PatientDetails = new List<PatientDetail>();
            foreach(var bookingPageItem in BookingPageItems)
            {
                var patientDetail = new PatientDetail
                {
                    Amount = bookingPageItem.Amount,
                    AppointmentId = bookingPageItem.Appointment.AppointmentId,
                    Appointment = bookingPageItem.Appointment,
                    ConsultationFee = bookingPageItem.ConsultationFee
                };

                patient.PatientDetails.Add(patientDetail);
            }

            _appDbContext.Patients.Add(patient);

            _appDbContext.SaveChanges();

        }
    }
}
