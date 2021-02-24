using System;
using System.Collections.Generic;
using Docter_MVC_Miniproject3.Models;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Views.ViewModels
{
    public class DoctorsListViewModel
    {
        public DoctorsListViewModel()
        {
        }

        public IEnumerable<Doctor> Doctors { get; set; }
        public string CurrentCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
