using System;
using System.Collections.Generic;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Models
{
    public class Category
    {
        public Category()
        {
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
