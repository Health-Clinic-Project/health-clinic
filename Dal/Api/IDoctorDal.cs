using Webapi.models;

namespace Dal.Api
{
    public interface IDoctorDal: ICRUD<Doctor>
    {
        Task<Doctor> GetDoctorBySpecialization(string doctorSpecialization);
        public Task<Doctor> GetById(string id);
        public bool Exists(string patientId);
    }
}