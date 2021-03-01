using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docter_MVC_Miniproject3.Data;
using Docter_MVC_Miniproject3.Models;
using Docter_MVC_Miniproject3.Views.ViewModels;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Docter_MVC_Miniproject3.Controllers
{
    public class PatientDetailsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly PatientDetail _patientDetail;
       

        public PatientDetailsController(ApplicationDbContext applicationDbContext, PatientDetail _patientDetail)
        {
            _applicationDbContext = applicationDbContext;

            
        }


      //  [HttpGet]
        //public ViewResult Index()
        //{
        //    var items = _patientDetail.PatientDetails;


        //    PatientViewModel patientViewModel = new PatientViewModel();
        //    patientViewModel.appointments = (IEnumerable<Appointment>)items;

        //    return View(patientViewModel);
        //}



        //// GET: /<controller>/
        //public RedirectToActionResult Details(int ID)
        //{


        //    if (ID != null)
        //    {
        //        var list = _applicationDbContext.PatientDetails.Where(c => c.PatientId == ID).Include(c => c.Appointment).ToList();
        //    }

        //    return RedirectToAction("Index");
        //}


    }



}

