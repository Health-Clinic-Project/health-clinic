using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapi.models;

namespace Dal.Models
{
    public class BasicAppointment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string DoctorId { get; set; } = null!;

        public string PatientId { get; set; } = null!;

        public virtual Doctor Doctor { get; set; } = null!;

        public virtual Patient Patient { get; set; } = null!;
    }
}
