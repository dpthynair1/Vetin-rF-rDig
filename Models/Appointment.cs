using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_MVC_Miniproject3.Models
{
    public class Appointment
    {
        public Appointment()
        {
        }

        public Appointment(int appointmentId, DateTime dateTime, int doctorId, Doctor doctor, int patientId, Patient patient)
        {
            AppointmentId = appointmentId;
            DateTime = dateTime;
            DoctorId = doctorId;
            Doctor = doctor;
            PatientId = patientId;
            Patient = patient;
        }

        public int AppointmentId { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor{ get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public Boolean IsAvailable { get; set; }


    }
}
