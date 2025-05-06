using Webapi.models;

namespace Dal.Api
{
    internal interface IPatientDal: ICRUD<Patient>
    {
        List<Patient> GetAllPatients();
        Patient GetClassId(string patientId);
    }
}