using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
    interface IAppointmentReposirory
    {
        IEnumerable<Appointment> AllAppointments { get; }
    }
}
