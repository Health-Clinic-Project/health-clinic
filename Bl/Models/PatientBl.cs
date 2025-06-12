using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class PatientBl
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int Age { get; set; }

    public int? Weight { get; set; }

    //public virtual ICollection<AvailableAppointmentBl> AvailableAppointments { get; set; } = new List<AvailableAppointmentBl>();

    //public virtual ICollection<NotAvailableAppointmentBl> NotAvailableAppointments { get; set; } = new List<NotAvailableAppointmentBl>();

    //public virtual ICollection<PassedAppointmentBl> PassedAppointments { get; set; } = new List<PassedAppointmentBl>();
}
