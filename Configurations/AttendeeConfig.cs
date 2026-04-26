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
    public class AttendeeConfig : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(x=>x.HomeAddress)
                   .WithOne(x=>x.Attendee)
                .HasForeignKey<Attendee>(x=>x.AddressId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Badge)
                    .WithOne(x => x.Attendee)
                    .HasForeignKey<Attendee>(x => x.BadgeId);

            builder.HasMany(x => x.Registrations)
                    .WithOne(x => x.Attendee)
                    .HasForeignKey(x => x.AttendeeId);
        }
    }
}
