using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bl.Api
{
    public interface IBlManager
    {
        public IDoctorManager DoctorManager { get; }
        public IPatientManager PatientManager { get; }

    }
}
