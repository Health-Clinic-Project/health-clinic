using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class Doctor
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public double SalaryPerHour { get; set; }

    public string Specialization { get; set; } = null!;

    public int LengthOfAppointment { get; set; }

    public virtual ICollection<AvailableAppointment> AvailableAppointments { get; set; } = new List<AvailableAppointment>();

    public virtual ICollection<NotAvailableAppointment> NotAvailableAppointments { get; set; } = new List<NotAvailableAppointment>();

    public virtual ICollection<PassedAppointment> PassedAppointments { get; set; } = new List<PassedAppointment>();

    public virtual ICollection<WorkHour> WorkHours { get; set; } = new List<WorkHour>();
}
