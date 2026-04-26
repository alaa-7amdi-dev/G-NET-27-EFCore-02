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
    internal class ProfileConfig : IEntityTypeConfiguration<ProfilePage>
    {
        public void Configure(EntityTypeBuilder<ProfilePage> builder)
        {
            builder.ToTable("OrganizeProfile");
        }
    }
}
