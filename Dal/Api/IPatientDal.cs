using Webapi.models;

namespace Dal.Api
{
    public interface IPatientDal: ICRUD<Patient>
    {
        Task<Patient> GetClassId(string patientId);
        public Task DeleteByIdAndPhoneNumber(string id, string phone);
        public Task<Patient> GetById(string id);
        public bool Exists(string patientId);
        //public Task<List<Patient>> GetByIds(List<String> patientIds);

    }
}