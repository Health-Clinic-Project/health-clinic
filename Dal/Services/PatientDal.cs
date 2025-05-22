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
        public async Task DeleteByIdAndPhoneNumber(string id,string phone)
        {
            Patient patient = GetById(id).Result;
            if (patient != null)
            {
                Delete(patient);
            }
            else { 
                throw new Exception(); 
            }
        }

        public async Task<List<Patient>> GetAll()
        {
            return await _dbManager.Patients.ToListAsync();
        }
        public async Task<Patient> GetById(string id)
        {
            return await _dbManager.Patients.FirstOrDefaultAsync(p=>p.Id.Equals(id));
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
        public bool Exists(string patientId)
        {
            if(GetById(patientId).Result!=null)
                return true;
            else return false;
        }

        //public async Task<List<Patient>> GetByIds(List<String> patientIds)
        //{
        //    return await _dbManager.Patients.Where(p => patientIds.Contains(p.Id)).ToListAsync();
        //}
    }
}
