using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Api
{
    internal interface IBlManager
    {
        public IDoctorDal DoctorDal { get; }
        public IPatientDal PatientDal { get; }
        public IAvailableAppointmentDal AvailableAppointmentDal { get; }
    }
}
