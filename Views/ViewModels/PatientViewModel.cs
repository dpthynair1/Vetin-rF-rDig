using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class PatientViewModel
    {
        public PatientViewModel()
        {
        }


        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        
       

        public int AppointmentId { get; set; }
        public Appointment appointment { get; }
        public IEnumerable<Appointment> appointments { get; set; }
        public IEnumerable<PatientDetail> PatientDetails { get; set; }






    }
}