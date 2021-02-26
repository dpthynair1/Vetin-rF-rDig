using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
   public interface IPatientRepository
    {
        public IEnumerable<Doctor> AllDoctors { get; }
        public IEnumerable<Appointment>  appointments { get; }
        public Patient GetPatient { get; }
        

        
    }
}
