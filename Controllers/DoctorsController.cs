using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Docter_MVC_Miniproject3.Data;
using Doctor_MVC_Miniproject3.Models;
using Microsoft.AspNetCore.Http;
using Docter_MVC_Miniproject3.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Docter_MVC_Miniproject3.Controllers
{
    [Authorize]
    public class DoctorsController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly ApplicationDbContext _context;
        private UploadInterface _upload;


        public DoctorsController(ApplicationDbContext context, UploadInterface upload, IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            _upload = upload;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
        }

        // GET: Doctors
        public IActionResult List()
        {
            DoctorsListViewModel doctorsListViewModel = new DoctorsListViewModel();
            doctorsListViewModel.Doctors = _doctorRepository.AllDoctors;

            return View(doctorsListViewModel);
        }

        //// GET: Doctors/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var doctor = await _context.Doctors.Include(m => m.Appointments)
        //        .FirstOrDefaultAsync(m => m.DoctorId == id);
        //    if (doctor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(doctor);
        //}

        // GET: Doctors/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }





        // POST: Doctors/Create
        [Authorize(Roles = "Doctor")]
        [HttpPost]
        public IActionResult Create(IList<IFormFile> files, DoctorViewModel vmodel, Doctor doctor)
        {
            doctor.DOctorName = vmodel.DoctorName;
            doctor.Specliazation = vmodel.Specialization;
            doctor.CategoryId = vmodel.CategoryId;
            foreach (var item in files)
            {
                doctor.ImageUrl = "~/uploads/" + item.FileName.Trim();

            }
            _upload.uploadfilemultiple(files);
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
             TempData["Success"] = "Doctor Added";

            return RedirectToAction("Create", "Doctors");
        }



        public IActionResult Details(int id)
        {
            //    var pie = _pieRepository.GetPieById(id);
            //    if (pie == null)
            //        return NotFound();

            //    return View(pie);
            // var appointments = _appointmentRepository.AllAppointments.Where(d => d.DoctorId == id).ToList();
            var appointments = _context.Appointments.Where(d => d.DoctorId == id).Include(a => a.Doctor).ToList();
            //AppointmentListViewModel appointmentListViewModel = new AppointmentListViewModel();
            //appointmentListViewModel.Appointments = appointments;
            DoctorsListViewModel doctorsListViewModel = new DoctorsListViewModel();
            doctorsListViewModel.Appointments = appointments;

            return View(doctorsListViewModel);

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DoctorId,DOctorName,Specliazation,ImageUrl")] Doctor doctor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(doctor);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(doctor);
        //}

        // GET: Doctors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,DOctorName,Specliazation,ImageUrl")] Doctor doctor)
        {
            if (id != doctor.DoctorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.DoctorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctors.Any(e => e.DoctorId == id);
        }
    }
}
