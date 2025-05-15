using Webapi.models;

namespace Dal.Api
{
    public interface IPatientDal: ICRUD<Patient>
    {
        Task<Patient> GetClassId(string patientId);
    }
}