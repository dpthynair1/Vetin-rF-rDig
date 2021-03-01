using System.Collections.Generic;
using System.Linq;
using Docter_MVC_Miniproject3.Data;
using Microsoft.EntityFrameworkCore;

namespace Doctor_MVC_Miniproject3.Models
{
    public class PatientDetail
    {
       
        public PatientDetail()
        {

        }
     


        public int PatientDetailId { get; set; }
        public int PatientId { get; set; }
        public int AppointmentId { get; set; }
        public int Amount { get; set; }
        public int ConsultationFee { get; set; }
        public Appointment Appointment { get; set; }
        public Patient Patient { get; set; }

       


    }


}