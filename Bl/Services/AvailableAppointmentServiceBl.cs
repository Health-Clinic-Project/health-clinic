using AutoMapper;
using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Bl.Services
{
    public class AvailableAppointmentServiceBl
    {
        private readonly IAvailableAppointmentDal availableAppointmentDal;
        private readonly IMapper mapper;

        public AvailableAppointmentServiceBl(IDal dal, IMapper _mapper)
        {
            availableAppointmentDal = dal.AvailableAppointmentDal;
            mapper = _mapper;
        }

        public void Add(AvailableAppointmentBl appointment)
        {
            if (appointment == null)
                throw new ArgumentNullException(nameof(appointment));
            if (appointment.Date < DateTime.Now)
                throw new ArgumentException("Cannot add appointment in the past");

            availableAppointmentDal.Add(mapper.Map<AvailableAppointment>(appointment));
        }

        public void Delete(AvailableAppointment appointment)
        {
            if (appointment == null)
                throw new ArgumentNullException(nameof(appointment));
            availableAppointmentDal.Delete(appointment);
        }

        public void Update(AvailableAppointment appointment)
        {
            if (appointment == null)
                throw new ArgumentNullException(nameof(appointment));
            if (appointment.Date < DateTime.Now)
                throw new ArgumentException("Cannot update appointment to past date");

            availableAppointmentDal.Update(appointment);
        }

        public List<AvailableAppointment> GetAll()
        {
            return availableAppointmentDal.GetAll();
        }

        public List<AvailableAppointment> GetAllAvailableAppointments()
        {
            return availableAppointmentDal.GetAll()
                .Where(a => a.DateTime > DateTime.Now)
                .OrderBy(a => a.DateTime)
                .ToList();
        }

        public List<AvailableAppointment> GetAppointmentsByDate(DateTime date)
        {
            return availableAppointmentDal.GetAll()
                .Where(a => a.DateTime.Date == date.Date)
                .OrderBy(a => a.DateTime)
                .ToList();
        }

        public List<AvailableAppointment> GetAllAvailableAppointmentsOfSpecialization(string specialization)
        {
            if (string.IsNullOrWhiteSpace(specialization))
                throw new ArgumentException("Specialization is required");

            return availableAppointmentDal.GetAll()
                .Where(a => a.DateTime > DateTime.Now && a.Doctor.Specialization == specialization)
                .OrderBy(a => a.DateT
        }
}
