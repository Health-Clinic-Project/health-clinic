using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Meeting
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
