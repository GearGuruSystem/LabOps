using LabOps.Domain.Entities;
using LabOps.Infra.Data.MapDataBase;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Situacao> Situacoes { get; set; } = null!;
        public DbSet<Fabricante> Fabricantes { get; set; } = null!;
        public DbSet<Laboratorio> Laboratorios { get; set; } = null!;
        public DbSet<Equipamento> Equipamentos { get; set; } = null!;
        public DbSet<TipoEquipamento> TiposEquipamento { get; set; } = null!;
        public DbSet<CaracteristicaTipo> CaracteristicaTipos { get; set; } = null!;
        public DbSet<CaracteristicaValor> CaracteristicasValor { get; set; } = null!;
        public DbSet<EquipamentoCaracteristica> EquipamentosCaracteristicas { get; set; } = null!;
        public DbSet<CaracteristicaTipoTipoEquipamento> CaracteristicasTipoTipoEquipamento { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapSituacao());
            modelBuilder.ApplyConfiguration(new MapFabricantes());
            modelBuilder.ApplyConfiguration(new MapLaboratorio());
            modelBuilder.ApplyConfiguration(new MapEquipamento());
            modelBuilder.ApplyConfiguration(new MapTipoEquipamento());
            modelBuilder.ApplyConfiguration(new MapCaracteristicaTipo());
            modelBuilder.ApplyConfiguration(new MapCaracteristicaValor());
            modelBuilder.ApplyConfiguration(new MapEquipamentoCaracteristica());
            modelBuilder.ApplyConfiguration(new MapCaracteristicaTipoTipoEquipamento());
        }
    }
}