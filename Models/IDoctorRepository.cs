using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
   public  interface IDoctorRepository
    {
        public IEnumerable<Appointment> AllAppointments { get; }
        public IEnumerable<Doctor> AllDoctors { get; }

        public Appointment GetAppointmentsById (int AppointmentId);
   }
}
