using System;
using System.Collections.Generic;
using System.Linq;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.EntityFrameworkCore;

namespace Docter_MVC_Miniproject3.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public PatientRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Doctor> AllDoctors => throw new NotImplementedException();

        

        public Patient GetPatient => throw new NotImplementedException();

        public IEnumerable<Appointment> appointments
        {
            get
            {
                return _appDbContext.Appointments.Include(c => c.AppointmentId);
            }
        }
    }
}
