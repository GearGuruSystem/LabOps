using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CaracteristicaTipo> CaracteristicaTipos { get; set; } = null!;
        public DbSet<CaracteristicaTipoTipoEquipamento> CaracteristicasTipoTipoEquipamento { get; set; } = null!;
        public DbSet<CaracteristicaValor> CaracteristicasValor { get; set; } = null!;
        public DbSet<Equipamento> Equipamentos { get; set; } = null!;
        public DbSet<EquipamentoCaracteristica> EquipamentosCaracteristicas { get; set; } = null!;
        public DbSet<Fabricante> Fabricantes { get; set; } = null!;
        public DbSet<Laboratorio> Laboratorios { get; set; } = null!;
        public DbSet<Situacao> Situacoes { get; set; } = null!;
        public DbSet<TipoEquipamento> TiposEquipamento { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaracteristicaTipo>()
                .HasKey(ct => ct.IDCaracteristicaTipo);

            modelBuilder.Entity<CaracteristicaTipoTipoEquipamento>()
                .HasKey(ctte => new { ctte.CaracteristicaTipo_ID, ctte.TipoEquipamento_ID });

            modelBuilder.Entity<CaracteristicaTipoTipoEquipamento>()
                .HasOne(ctte => ctte.CaracteristicaTipo)
                .WithMany(ct => ct.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.CaracteristicaTipo_ID);

            modelBuilder.Entity<CaracteristicaTipoTipoEquipamento>()
                .HasOne(ctte => ctte.TipoEquipamento)
                .WithMany(te => te.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.TipoEquipamento_ID);

            modelBuilder.Entity<CaracteristicaValor>()
                .HasKey(cv => cv.IDCaracteristicaValor);

            modelBuilder.Entity<Equipamento>()
                .HasKey(e => e.IDEquipamento);

            modelBuilder.Entity<EquipamentoCaracteristica>()
                .HasKey(ec => ec.IDEquipamentoCaracteristica);

            modelBuilder.Entity<EquipamentoCaracteristica>()
                .HasOne(ec => ec.CaracteristicaTipo)
                .WithMany()
                .HasForeignKey(ec => ec.IDCaracteristicaTipo);

            modelBuilder.Entity<EquipamentoCaracteristica>()
                .HasOne(ec => ec.CaracteristicaValor)
                .WithMany()
                .HasForeignKey(ec => ec.IDCaracteristicaValor);

            modelBuilder.Entity<Equipamento>()
                .HasOne(e => e.Fabricante)
                .WithMany()
                .HasForeignKey(e => e.IDFabricante);

            modelBuilder.Entity<Equipamento>()
                .HasOne(e => e.Laboratorio)
                .WithMany()
                .HasForeignKey(e => e.IDLaboratorio);

            modelBuilder.Entity<Equipamento>()
                .HasOne(e => e.Situacao)
                .WithMany()
                .HasForeignKey(e => e.IDSituacao);

            modelBuilder.Entity<Equipamento>()
                .HasOne(e => e.TipoEquipamento)
                .WithMany()
                .HasForeignKey(e => e.IDTipoEquipamento);

            modelBuilder.Entity<Fabricante>()
                .HasKey(f => f.IDFabricante);

            modelBuilder.Entity<Laboratorio>()
                .HasKey(l => l.IDLaboratorio);

            modelBuilder.Entity<Situacao>()
                .HasKey(s => s.IDSituacao);

            modelBuilder.Entity<TipoEquipamento>()
                .HasKey(te => te.IDTipoEquipamento);
        }
    }
}