using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class WorkHour
{
    public int Id { get; set; }

    public string DoctorId { get; set; } = null!;

    public int Day { get; set; }

    public double StartTime { get; set; }

    public double EndTime { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;
}
