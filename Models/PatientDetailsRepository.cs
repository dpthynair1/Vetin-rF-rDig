using System;
using System.Collections.Generic;
using System.Linq;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.EntityFrameworkCore;

namespace Docter_MVC_Miniproject3.Models
{
    public class PatientDetailsRepository: IPatientDetailsRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public PatientDetailsRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<PatientDetail> PatientDetails
        {

            get
            {
              return  _applicationDbContext.PatientDetails.Include(a => a.Appointment).Include(p => p.Patient);
            }
        }
        public IEnumerable<Appointment> AllAppointments => throw new NotImplementedException();

        

        public IEnumerable<Appointment> GetAppointments(int Id)
        {
            var appointment = _applicationDbContext.PatientDetails.Where(p => p.Patient.PatientId == Id).Include(a => a.Appointment).ToList();
            return (IEnumerable<Appointment>)appointment;
        }
    }
}

