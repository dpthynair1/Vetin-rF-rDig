using System;
using Doctor_MVC_Miniproject3.Models;

namespace Docter_MVC_Miniproject3.Models
{
    public interface IPatientRepository
    {
        void CreatePatient(Patient patient);
    }
}
