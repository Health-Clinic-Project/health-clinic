using Dal.Api;
using Dal.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Dal
{
    public class DalManager:IDal
    {

        public IDoctorDal DoctorDal { get; }
        public IPatientDal PatientDal { get; }
        public IAvailableAppointmentDal AvailableAppointmentDal { get; }
        public INotAvailableAppointmentDal NotAvailableAppointmentDal { get; }
        public IPassedAppointmentDal PassedAppointmentDal { get; }

        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<DB_Manager>();
            services.AddSingleton<IDoctorDal, DoctorDal>();
            services.AddSingleton<IPatientDal, PatientDal>();
            services.AddSingleton<IAvailableAppointmentDal, AvailableAppointmentDal>();
            services.AddSingleton<INotAvailableAppointmentDal, NotAvailableAppointmentDal>();
            services.AddSingleton<IPassedAppointmentDal, PassedAppointmentDal>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            DoctorDal = serviceProvider.GetService<IDoctorDal>();
            PatientDal = serviceProvider.GetService<IPatientDal>();
            AvailableAppointmentDal = serviceProvider.GetService<IAvailableAppointmentDal>();
            NotAvailableAppointmentDal = serviceProvider.GetService<INotAvailableAppointmentDal>();
            PassedAppointmentDal =serviceProvider.GetService<IPassedAppointmentDal>();
        }

 
    }
}
