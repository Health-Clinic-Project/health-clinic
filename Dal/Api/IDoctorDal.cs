using Webapi.models;

namespace Dal.Api
{
    internal interface IDoctorDal: ICRUD<Doctor>
    {
        Doctor GetDoctorBySpecialization(string doctorSpecialization);
    }
}