using System;
using System.ComponentModel.DataAnnotations.Schema;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Models
{
    public class BookingPageItem
    {
        public BookingPageItem()
        {
        }

        public int BookingPageItemId  { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }
        public int ConsultationFee { get; set; }





    }
}
