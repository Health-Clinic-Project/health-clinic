using AutoMapper;
using Dal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Bl.Services
{
    internal class DoctorManager
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

            if (patientDal.Exists(patientBl.Id))
                throw new InvalidOperationException("Doctor with this ID already exists.");

            var patient = mapper.Map<Patient>(patientBl);
            patientDal.Add(patient);

        }
    }
}
