using EFCore02.Modael;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=\\\\.\\pipe\\MSSQL$SQLEXPRESS\\sql\\query;Database=EventPlatform;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Organizer> organizers { get; set; }
        public DbSet<ProfilePage> profilePages { get; set; }
        public DbSet<Evient> Evients { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<HomeAddress> HomeAddresses { get; set; }
        public DbSet<Registrations> Registrations { get; set; }


    }
}
