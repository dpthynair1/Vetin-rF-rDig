using System;
using System.Collections.Generic;
using System.Linq;
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

       
        public IEnumerable<Appointment> GetAppointments(int Id)
        {
            var Appoinments = _appDbContext.Appointments.Where(a => a.DoctorId == Id).ToList();
            return Appoinments;
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
