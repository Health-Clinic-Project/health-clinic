using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Webapi.models;
using Bl.Api;

namespace Bl.Services
{
    internal class DoctorManager : IDoctorManager
    {
        private readonly IDoctorDal doctorDal;
        private readonly IMapper mapper;

        public DoctorManager(IDal dal, IMapper _mapper)
        {
            doctorDal = dal.DoctorDal;
            mapper = _mapper;
        }
        public void AddDoctor(DoctorBl doctorBl)
        {
            if (doctorBl == null)
                throw new ArgumentNullException(nameof(doctorBl));

            if (doctorDal.Exists(doctorBl.Id))
                throw new InvalidOperationException("Doctor with this ID already exists.");

            var doctor = mapper.Map<Doctor>(doctorBl);
            doctorDal.Add(doctor);
        }
        public void RemoveDoctor(string id, string phoneNumber)
        {

            doctorDal.DeleteByIdAndPhoneNumber(id, phoneNumber);
        }

        public DoctorBl GetDoctor(string id)
        {
            return mapper.Map<DoctorBl>(doctorDal.GetById(id));
        }
        public List<DoctorBl> GetDoctor()
        {
            var doctorList = doctorDal.GetAll();

            return mapper.Map<List<DoctorBl>>(doctorList);
        }
        public void UpdateDoctor(DoctorBl doctorBl)
        {
            if (doctorBl == null)
                throw new ArgumentNullException(nameof(doctorBl));

            if (!doctorDal.Exists(doctorBl.Id))
                throw new InvalidOperationException("Doctor does not exist.");

            var doctor = mapper.Map<Doctor>(doctorBl);
            doctorDal.Update(doctor);
        }
    }
}
