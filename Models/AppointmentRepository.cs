using System;
using System.Collections.Generic;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Docter_MVC_Miniproject3.Models
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public AppointmentRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


       
        

        public IEnumerable<Appointment> AllAppointments
        {
            get

            {
                return _appDbContext.Appointments.Include(c => c.Doctor);
            }
        }

        public IEnumerable<Doctor> Doctors

        {
            get

            {
                return _appDbContext.Doctors.Include(c => c.Appointments);
            }
        }

    }

}

