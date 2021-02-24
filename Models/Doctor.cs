using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docter_MVC_Miniproject3.Models;

namespace Doctor_MVC_Miniproject3.Models
{
    public class Doctor
    {
        public Doctor()
        {
        }

        

        public int DoctorId { get; set; }
        public string  DOctorName { get; set; }
        public string Specliazation { get; set; }

        public string ImageUrl { get; set; }
        public List<Appointment> Appointments { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
