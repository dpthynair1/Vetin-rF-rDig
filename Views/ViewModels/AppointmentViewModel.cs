using System;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class AppointmentViewModel
    {
        public AppointmentViewModel()
        {
        }

        
        public int AppointmentId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        

        public int DoctorId { get; set; }    
        public Doctor Doctor { get; set; }
        

        public Boolean IsAvailable = true;
        public TimeSpan Duration1 { get; }

        string Name;
        
    }


    
}
