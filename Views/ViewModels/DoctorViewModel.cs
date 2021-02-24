using System;
namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class DoctorViewModel
    {
        public DoctorViewModel()
        {
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }

        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
