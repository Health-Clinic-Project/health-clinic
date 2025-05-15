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
    internal class AvailableAppointmentDal : IAvailableAppointmentDal
    {
        private readonly DB_Manager _dbManager;
        public AvailableAppointmentDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task Add(AvailableAppointment availableAppointment)
        {
            await _dbManager.AvailableAppointments.AddAsync(availableAppointment);
            await _dbManager.SaveChangesAsync();
        }

        public async Task Delete(AvailableAppointment availableAppointment)
        {
            _dbManager.AvailableAppointments.Remove(availableAppointment);
            await _dbManager.SaveChangesAsync();
        }
        public async Task CancleByIdAndDate(string id, DateTime date)
        {
            var app = await _dbManager.AvailableAppointments.FirstOrDefaultAsync(a => a.Id.Equals(id) && a.Date.Equals(date));
            if (app == null)
            {
               Delete(app);
            }
            else throw new Exception();
        }

        public async Task<List<AvailableAppointment>> GetAll()
        {
            return await _dbManager.AvailableAppointments.ToListAsync();
        }

        public async Task<List<AvailableAppointment>> GetAllAvailableAppointment()
        {
            return await _dbManager.AvailableAppointments.Where(d => d.Date > DateTime.Now).ToListAsync();
        }
        public async Task<List<AvailableAppointment>> GetAllAvailableAppointmentsOfSpecialization(string specialty)
        {

            return await _dbManager.AvailableAppointments.Where(a => a.Date > DateTime.Now && a.Doctor.Specialization == specialty).ToListAsync();
        }

        public async Task Update(AvailableAppointment availableAppointment)
        {
            _dbManager.AvailableAppointments.Update(availableAppointment);
            await _dbManager.SaveChangesAsync();
        }


    }
}
