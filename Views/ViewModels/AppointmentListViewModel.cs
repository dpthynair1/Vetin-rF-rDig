using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class AppointmentListViewModel
    {
        public AppointmentListViewModel()
        {
        }
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        
    }
}
