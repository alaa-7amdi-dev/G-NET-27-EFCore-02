using EFCore02.Modael;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Configurations
{
    internal class EventConfig : IEntityTypeConfiguration<Evient>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Evient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Event");
            builder.HasOne(x => x.organizer)
                   .WithMany(x => x.Evients)
                   .HasForeignKey(x => x.OrganizerId);

            builder.HasMany(x => x.ParentEvent)
                            .WithOne()
                            .HasForeignKey(x => x.ParentId)
                            .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Registrations)
                    .WithOne(x => x.Evient)
                    .HasForeignKey(x => x.EvientId);

        }
    }
}
