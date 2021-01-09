using Entities.Abstract.MiddleTables;
using Entities.Abstract.MiddleTables.RFQMiddles;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class CNCContext : DbContext
    {
        public DbSet<RFQ> RFQs { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CompanySize> CompanySizes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Technology> Technologies { get; set; }

        //Middle Tables
        public DbSet<UserTechnology> UserTechologies { get; set; }
        public DbSet<UserCertification> UserCertifications { get; set; }
        public DbSet<UserMaterial> UserMaterials { get; set; }
        public DbSet<UserIndustry> UserIndustries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<RfqCountry> RfqCountries { get; set; }
        public DbSet<Iller> Illers { get; set; }
        public DbSet<RfqFile> RfqFiles { get; set; }
        public DbSet<RfqCertification>  RfqCertifications{ get; set; }
        public DbSet<RfqTechnology>  RfqTechnologies { get; set; }
        public DbSet<RfqMaterial>  RfqMaterials { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CNC;Trusted_Connection=True;");
        }
    }
}
