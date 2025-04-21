using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int Age { get; set; }

    public int Weight { get; set; }

    public int MedicalBag { get; set; }

    public virtual Meeting MedicalBagNavigation { get; set; } = null!;
}
