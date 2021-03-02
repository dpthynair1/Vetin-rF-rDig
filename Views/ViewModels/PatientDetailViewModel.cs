using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class PatientDetailViewModel
    {
        public PatientDetailViewModel()
        {
        }


        public IEnumerable<PatientDetail> PatientDetails { get; set; }
    }
}
