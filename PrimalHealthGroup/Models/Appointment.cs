using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimalHealthGroup.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime DateTime { get; set; }
        public Location Location { get; set; }
    }
}
