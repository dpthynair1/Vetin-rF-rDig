using Docter_MVC_Miniproject3.Models;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Docter_MVC_Miniproject3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
      
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookingPageItem> BookingPageItems { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }

    }
}
