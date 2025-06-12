using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl;
using AutoMapper;
using Webapi.models; 

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AvailableAppointmentBl, AvailableAppointment>().ReverseMap();
        CreateMap<NotAvailableAppointmentBl, NotAvailableAppointment>().ReverseMap();
        CreateMap<PassedAppointmentBl, PassedAppointment>().ReverseMap();
        CreateMap<PatientBl, Patient>().ReverseMap();
        CreateMap<DoctorBl, Doctor>().ReverseMap();

    }
}

