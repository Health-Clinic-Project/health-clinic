using Dal.Api;
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

        public void Add(Patient patient)
        {
            _dbManager.Patients.Add(patient);
        }

        public void Delete(Patient patient)
        {
            _dbManager.Patients.Remove(patient);
        }

        public List<Patient> GetAll()
        {
            return _dbManager.Patients.ToList();
        }

        public Patient GetClassId(string patientId)
        {
            var patient = _dbManager.Patients.FirstOrDefault(t => t.Id == patientId);
            if (patient != null)
            {
                return patient;
            }
            else throw new NullReferenceException();
        }

        public void Update(Patient patient)
        {
            _dbManager.Patients.Update(patient);
        }
    }
}
