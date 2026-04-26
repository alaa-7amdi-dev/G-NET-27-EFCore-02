using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class Registrations
    {
        public int RegistrationsId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public Attendee Attendee { get; set; }
        public int AttendeeId { get; set; }
        public Evient Evient { get; set; }
        public int EvientId { get; set; }
    }
}
