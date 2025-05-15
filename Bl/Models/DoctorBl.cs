using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class DoctorBl
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public double SalaryPerHour { get; set; }

    public string Specialization { get; set; } = null!;

    public int LengthOfAppointment { get; set; }

    public virtual ICollection<AvailableAppointmentBl> AvailableAppointments { get; set; } = new List<AvailableAppointmentBl>();

    public virtual ICollection<NotAvailableAppointmentBl> NotAvailableAppointments { get; set; } = new List<NotAvailableAppointmentBl>();

    public virtual ICollection<PassedAppointmentBl> PassedAppointments { get; set; } = new List<PassedAppointmentBl>();

    public virtual ICollection<BlStartWorkHour> WorkHours { get; set; } = new List<BlStartWorkHour>();
}
