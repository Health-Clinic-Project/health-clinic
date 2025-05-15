using Webapi.models;

namespace Dal.Api
{
    public interface IPassedAppointmentDal:ICRUD<PassedAppointment>
    {
        Task<List<PassedAppointment>> GetAllAvailableAppointmentsOfSpecialization(string specialty);
    }
}