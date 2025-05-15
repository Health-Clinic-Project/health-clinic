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
    internal class PatientDal : IPatientDal
    {
        private readonly DB_Manager _dbManager;

        public PatientDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task Add(Patient patient)
        {
            await _dbManager.Patients.AddAsync(patient);
            await _dbManager.SaveChangesAsync();
        }

        public async Task Delete(Patient patient)
        {
            _dbManager.Patients.Remove(patient);
            await _dbManager.SaveChangesAsync();
        }

        public async Task<List<Patient>> GetAll()
        {
            return await _dbManager.Patients.ToListAsync();
        }

        public async Task<Patient> GetClassId(string patientId)
        {
            var patient = await _dbManager.Patients.FirstOrDefaultAsync(t => t.Id == patientId);
            await _dbManager.SaveChangesAsync();
            if (patient != null)
            {
                return patient;
            }
            else throw new NullReferenceException();
        }

        public async Task Update(Patient entity)
        {
            _dbManager.Patients.Update(entity);
            await _dbManager.SaveChangesAsync();
        }
    }
}
