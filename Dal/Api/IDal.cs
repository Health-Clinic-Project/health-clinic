using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    public interface IDal
    {
        public IDoctorDal DoctorDal { get; }
        public IPatientDal PatientDal { get; }
        public IAvailableAppointmentDal AvailableAppointmentDal { get; }
        public INotAvailableAppointmentDal NotAvailableAppointmentDal { get; }
        public IPassedAppointmentDal PassedAppointmentDal { get; }
    }
}
