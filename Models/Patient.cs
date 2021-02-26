using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docter_MVC_Miniproject3.Controllers;

namespace Doctor_MVC_Miniproject3.Models
{
    public class Patient
    {
        public Patient()
        {
           
        }

        //public Patient(int patientId, string patientName, int age, List<Doctor> doctors, string doctorName, string email, DateTime dateTime)
        //{
        //    PatientId = patientId;
        //    PatientName = patientName;
        //    Age = age;
        //    Doctors = doctors;
        //    DoctorName = doctorName;
        //    Email = email;
        //    DateTime = dateTime;

        //}

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public List<Doctor> Doctors { get; set; }
        public DateTime DateTime { get; set; }
        public string DoctorName { get; set; }
        public string Email { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }



    }
}
