using Dal.Api;
using Microsoft.EntityFrameworkCore;
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

        public async Task Add(Doctor doctor)
        {
            await _dbManager.Doctors.AddAsync(doctor);
            await _dbManager.SaveChangesAsync();
        }

        public async Task Delete(Doctor doctor)
        {
            _dbManager.Doctors.Remove(doctor);
            await _dbManager.SaveChangesAsync();
        }

        public async Task<List<Doctor>> GetAll()
        {
            return await _dbManager.Doctors.ToListAsync();
        }
       
        public async Task<Doctor> GetDoctorBySpecialization(string doctorSpecialization)
        {
            var doctor = await _dbManager.Doctors.FirstOrDefaultAsync(t => t.Specialization == doctorSpecialization);
            await _dbManager.SaveChangesAsync();
            if (doctor != null)
            {
                return doctor;
            }
            else throw new NullReferenceException();
        }

        public async Task Update(Doctor doctor)
        {
            _dbManager.Doctors.Update(doctor);
            await _dbManager.SaveChangesAsync();
        }
    }
}
