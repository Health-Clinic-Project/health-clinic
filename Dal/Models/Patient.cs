using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class Patient
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int Age { get; set; }

    public int? Weight { get; set; }

    public virtual ICollection<AvailableAppointment> AvailableAppointments { get; set; } = new List<AvailableAppointment>();

    public virtual ICollection<NotAvailableAppointment> NotAvailableAppointments { get; set; } = new List<NotAvailableAppointment>();

    public virtual ICollection<PassedAppointment> PassedAppointments { get; set; } = new List<PassedAppointment>();
}
