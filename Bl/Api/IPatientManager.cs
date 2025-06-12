using Webapi.models;

namespace Bl.Api
{
    public interface IPatientManager
    {
        void AddPatient(PatientBl patientBl);
        PatientBl GetPatient(string id);
        List<PatientBl> GetPatients();
        //string GetPatients();

        List<PatientBl> GetPatientsAppointmentByDate(DateTime date);
        List<PatientBl> GetPatientsByDoctorId(DateTime date, string doctorId);
        void RemovePatient(string id, string phoneNumber);
        void UpdatePatient(PatientBl patientBl);
    }
}