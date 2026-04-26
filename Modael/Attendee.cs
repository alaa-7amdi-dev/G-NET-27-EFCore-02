using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public HomeAddress HomeAddress { get; set; }
        public int AddressId { get; set; }
        public Badge Badge { get; set; }
        public Guid BadgeId { get; set; }
        public ICollection<Registrations> Registrations { get; set; }


    }
}
