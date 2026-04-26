using EFCore02.Modael;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Configurations
{
    public class OrganizerConfig : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x=>x.OrgainzeProfile)
                   .WithOne(x=>x.Orgaizer)
                   .HasForeignKey<ProfilePage>(x=>x.OriganizrId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("Organizers");


         
        }
    }
}
