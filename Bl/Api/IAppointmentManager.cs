using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Webapi.models;
namespace Bl.Api
{
    public interface IAppointmentManager
    {
        Task<List<AvailableAppointmentBl>> GetAllAvailableAppointments();

        Task<List<NotAvailableAppointmentBl>> GetAppointmentsByDate(DateTime date);

        Task<List<PassedAppointmentBl>> GetAllPassedAppointments();

        Task BookAppointment(int availableAppointmentId, string patientId);

        Task CompleteAppointment(int notAvailableAppointmentId, string description, bool didArrive);
        NotAvailableAppointmentBl MakeAnAppointment(AvailableAppointmentBl availableAppointmentBl);
    }
}

