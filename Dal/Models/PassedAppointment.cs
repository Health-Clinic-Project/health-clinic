using Dal.Models;
using System;
using System.Collections.Generic;

namespace Webapi.models;

public partial class PassedAppointment:BasicAppointment
{    
    public string? Description { get; set; }

    public bool DidThePatientArrive { get; set; }

}
