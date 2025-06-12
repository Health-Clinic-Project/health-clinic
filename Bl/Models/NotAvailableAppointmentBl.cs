using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class NotAvailableAppointmentBl
{
    public DateTime Date { get; set; }

    public string DoctorId { get; set; } = null!;

    public string PatientId { get; set; } = null!;

}
