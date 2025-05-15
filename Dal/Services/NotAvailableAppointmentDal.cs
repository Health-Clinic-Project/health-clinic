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
    internal class NotAvailableAppointmentDal:INotAvailableAppointmentDal 
    {
        private readonly DB_Manager _dbManager;
        public NotAvailableAppointmentDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task Add(NotAvailableAppointment notAvailableAppointment)
        {
            await _dbManager.NotAvailableAppointments.AddAsync(notAvailableAppointment);
            await _dbManager.SaveChangesAsync();
        }

        public async Task Delete(NotAvailableAppointment notAvailableAppointment)
        {
             _dbManager.NotAvailableAppointments.Remove(notAvailableAppointment);
            await _dbManager.SaveChangesAsync();
        }
        public async Task CancleByIdAndDate(string id, DateTime date)
        {
            var app = await _dbManager.NotAvailableAppointments.FirstOrDefaultAsync(a => a.Id.Equals(id) && a.Date.Equals(date));
            if (app == null)
            {
                Delete(app);
            }
            else throw new Exception();
        }
        public async Task<List<NotAvailableAppointment>> GetAll()
        {
           return await _dbManager.NotAvailableAppointments.ToListAsync();
        }

        public Task<List<AvailableAppointment>> GetAllAvailableAppointmentsOfSpecialization(string specialty)
        {
            throw new NotImplementedException();
        }

        public async Task Update(NotAvailableAppointment notAvailableAppointment)
        {
            _dbManager.NotAvailableAppointments.Update(notAvailableAppointment);
            await _dbManager.SaveChangesAsync();
        }
    }
}
