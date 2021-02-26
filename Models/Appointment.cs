using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
    public class Appointment
    {
        public Appointment()
        {
        }
        TimeSpan ts = new TimeSpan();


        public int AppointmentId { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor{ get; set; }

        //public int? PatientId { get; set; }
        //public Patient Patient { get; set; }

        public Boolean IsAvailable { get; set; }
        
        public TimeSpan Duration
        {
            get
            {
                return ts = EndTime.Subtract(DateTime);
            }
            set
            {
                ts = EndTime.Subtract(DateTime);
            }
            

        }

        
    }



    }

