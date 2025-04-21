using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Doctor
{
    public string Id { get; set; } = null!;

    public string? FirstName { get; set; }

    public string Lastname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public double SalaryPerHour { get; set; }

    public string Specialization { get; set; } = null!;

    public string WorkingDays { get; set; } = null!;

    public string WorkingHours { get; set; } = null!;
}
