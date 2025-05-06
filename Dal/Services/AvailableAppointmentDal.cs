using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Dal.Services
{
    internal class AvailableAppointmentDal
    {
        private readonly DB_Manager _dbManager;
        public AvailableAppointmentDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }
        public List<AvailableAppointment> GetAllAvailableAppointment()
        {
            return _dbManager.AvailableAppointments.Where(d=>d.Date>DateTime.Now).ToList();
        }
        public List<AvailableAppointment> GetAllAvailableAppointmentsOfSpecialization(string specialty)
        {

            return _dbManager.AvailableAppointments.Where(a => a.Date > DateTime.Now && a.Doctor.Specialization == specialty).ToList();
        }

    }
}
