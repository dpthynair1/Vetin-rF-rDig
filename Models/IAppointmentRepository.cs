using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
  public  interface IAppointmentRepository
    {
       IEnumerable<Appointment> AllAppointments { get; }
       IEnumerable<Doctor> Doctors { get; }
        IEnumerable<Appointment> AppointmentsAvailable { get; }
    }
}
