using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Dal.Api
{
    public interface IAvailableAppointmentDal : ICRUD<AvailableAppointment>
    {
        public Task<List<AvailableAppointment>> GetAllAvailableAppointment();
        public Task<List<AvailableAppointment>> GetAllAvailableAppointmentsOfSpecialization(string specialty);
        public Task<AvailableAppointment> GetByIdAndDate(string id, DateTime date);
        public Task CancleByIdAndDate(string id, DateTime date);

    }

}
