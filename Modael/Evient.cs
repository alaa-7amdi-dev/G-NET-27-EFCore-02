using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class Evient
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxAttendees { get; set; }
        [InverseProperty(nameof(Organizer.Evients))]
        public Organizer organizer { get; set; }
        public int OrganizerId { get; set; }

        public ICollection<Evient> ParentEvent { get; set; }
        public int ParentId { get; set; }

        public ICollection<Registrations> Registrations { get; set; }
    }
}
