using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Modael
{
    public class ProfilePage
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Short_biography { get; set; }
        public string  Email { get; set; }
        public string CompanyWebsite { get; set; }
        public string Logo { get; set; }
        public int OriganizrId { get; set; }
        public Organizer Orgaizer { get; set; }

    }
}
