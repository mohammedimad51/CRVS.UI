using CRVS.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.EF
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

              : base(options)
        { 
        }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public DbSet<Disable> Disables { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Doh> Dohs { get; set; }
        public DbSet<FacilityType> FacilityTypes { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<HealthInstitution> HealthInstitutions { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Nahia> Nahias { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<User> Users { get; set; }




    }

}
