using System;
using System.Collections.Generic;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.EntityFrameworkCore;

namespace Docter_MVC_Miniproject3.Models
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public DoctorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Appointment> AllAppointments => throw new NotImplementedException();

       
        public Appointment GetAppointmentsById(int AppointmentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> AllDoctors
        {
            get

            {
                return _appDbContext.Doctors.Include(c => c.Category);
            }
        }
    }
}
