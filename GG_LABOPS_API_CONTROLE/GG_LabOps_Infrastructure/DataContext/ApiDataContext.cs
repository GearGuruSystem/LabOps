using GG_LabOps_Domain.Entities;
using GG_LabOps_Infrastructure.ConfigurationData;
using Microsoft.EntityFrameworkCore;

namespace GG_LabOps_Infrastructure.DataContext
{
    public class ApiDataContext : DbContext
    {
        public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
        {
        }

        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<BrandEquipament> BrandEquipaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LaboratoryConfig());
            modelBuilder.ApplyConfiguration(new  BrandEquipamentConfig());
        }
    }
}
