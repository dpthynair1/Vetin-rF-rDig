using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Models
{
    public interface IPatientDetailsRepository
    {
        public IEnumerable<PatientDetail> PatientDetails { get; }
        public IEnumerable<Appointment> AllAppointments { get; }
      //  public IEnumerable<Patient> AllPatients { get; }

        public IEnumerable<Appointment> GetAppointments(int Id);
    }
}
