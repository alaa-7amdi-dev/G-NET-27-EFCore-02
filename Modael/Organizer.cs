using EFCore02.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class Organizer

    {
        public int Id { get; set; }
        public string OrganizerName { get; set; }
        public string CompanyName { get; set; }
        public VerifitedStatus verifitedStatus { get; set; }
        public ProfilePage OrgainzeProfile { get; set; }

        [InverseProperty(nameof(Evient.organizer))]
        public ICollection<Evient> Evients { get; set; }
      

    }
}
