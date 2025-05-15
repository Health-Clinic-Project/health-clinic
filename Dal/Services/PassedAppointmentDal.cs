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
    internal class PassedAppointmentDal : IPassedAppointmentDal
    {
        private readonly DB_Manager _dbManager;
        public PassedAppointmentDal(DB_Manager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task Add(PassedAppointment passedAppointment)
        {
            await _dbManager.PassedAppointments.AddAsync(passedAppointment);
            await _dbManager.SaveChangesAsync();
        }

        public async Task Delete(PassedAppointment passedAppointment)
        {
            _dbManager.PassedAppointments.Remove(passedAppointment);
            await _dbManager.SaveChangesAsync();
        }

        public async Task<List<PassedAppointment>> GetAll()
        {
            return await _dbManager.PassedAppointments.ToListAsync();
        }

        public Task<List<PassedAppointment>> GetAllAvailableAppointmentsOfSpecialization(string specialty)
        {
            throw new NotImplementedException();
        }

        public async Task Update(PassedAppointment passedAppointment)
        {
            _dbManager.PassedAppointments.Update(passedAppointment);
            await _dbManager.SaveChangesAsync();
        }
    }

}

