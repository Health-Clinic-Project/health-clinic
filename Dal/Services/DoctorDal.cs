using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Dal.Services
{
    internal class DoctorDal : IDoctorDal
    {
        private readonly DB_Manager _dbManager;
        public DoctorDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }

        public List<Doctor> GetAllDoctors()
        {
            return _dbManager.Doctors.ToList();
        }
        public Doctor GetDoctorBySpecialization(string doctorSpecialization)
        {
            var doctor = _dbManager.Doctors.FirstOrDefault(t => t.Specialization == doctorSpecialization);
            if (doctor != null)
            {
                return doctor;
            }
            else throw new NullReferenceException();
        }
    }
}
