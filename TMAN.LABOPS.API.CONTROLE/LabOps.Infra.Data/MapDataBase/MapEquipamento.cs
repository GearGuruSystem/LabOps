using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapEquipamento : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("Tb_Equipamento");

            #region Proprieties

            builder.Property(e => e.Id)
                .HasColumnName("Cl_IdEquipamento")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("Cl_Nome")
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(e => e.UsuarioInsercao)
                .HasColumnName("Cl_UsuarioInsercao")
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.AtualizadoEm)
                .HasColumnName("Cl_AtualizadoEm")
                .IsRequired();

            builder.Property(e => e.IdSituacao)
                .HasColumnName("Cl_IdSituacao")
                .IsRequired();

            builder.Property(e => e.IdTipoEquipamento)
                .HasColumnName("Cl_IdTipoEquipamento")
                .IsRequired();

            builder.Property(e => e.IdFabricante)
                .HasColumnName("Cl_IdFabricante")
                .IsRequired();

            builder.Property(e => e.Hostname)
                .HasColumnName("Cl_Hostname");

            builder.Property(e => e.Inventario)
                .HasColumnName("Cl_Inventario");

            builder.Property(e => e.SerialNumber)
                .HasColumnName("Cl_SerialNumber")
                .IsRequired();

            #endregion Propriedades

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Situacao)
                .WithMany(e => e.Equipamentos)
                .HasForeignKey(e => e.IdSituacao)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.TipoEquipamento)
                .WithMany(e => e.Equipamentos)
                .HasForeignKey(e => e.IdTipoEquipamento)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Fabricante)
                .WithMany(e => e.Equipamentos)
                .HasForeignKey(e => e.IdFabricante)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Laboratorio)
                .WithMany(e => e.Equipamentos);
        }
    }
}