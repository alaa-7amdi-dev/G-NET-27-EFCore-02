using EFCore02.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class Badge
    {
        [Key]
        public Guid BadgeNum  { get; set; }
        public DateTime IssuedDate { get; set; }
        public Tier tier { get; set; }
        public Attendee Attendee { get; set; }
    }
}
