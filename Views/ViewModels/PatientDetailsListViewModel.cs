using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class PatientAppointmentListviewModel
    {
        public PatientAppointmentListviewModel()
        {
        }

      
        public Patient Patient { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
        
    }
}
