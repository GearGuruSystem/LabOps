using GG_LabOps_Domain.Entities;
using GG_LabOps_Infrastructure.ConfigurationDB;
using Microsoft.EntityFrameworkCore;

namespace GG_LabOps_Infrastructure.DataContext
{
    public class ApiDataContext : DbContext
    {
#pragma warning disable IDE0290 // Use primary constructor
        public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
        {
        }

        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<Equipament> Equipaments { get; set; }
        public DbSet<BrandEquipament> BrandEquipaments { get; set; }
        public DbSet<ModelEquipament> ModelsEquipaments { get; set; }
        public DbSet<TypeEquipament> TypeEquipaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LaboratoryConfig());
            modelBuilder.ApplyConfiguration(new EquipamentConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new ModelConfig());
            modelBuilder.ApplyConfiguration(new TypeConfig());
        }
    }
}
