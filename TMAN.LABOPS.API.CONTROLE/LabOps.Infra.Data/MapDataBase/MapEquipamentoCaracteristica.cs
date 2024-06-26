using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapEquipamentoCaracteristica : IEntityTypeConfiguration<EquipamentoCaracteristica>
    {
        public void Configure(EntityTypeBuilder<EquipamentoCaracteristica> builder)
        {
            builder.ToTable("Tb_EquipamentoCaracteristica");
            builder.HasKey(ec => ec.Id);

            #region Proprieties

            builder.Property(ec => ec.IdEquipamento)
                .HasColumnName("Cl_IdEquipamentos");

            builder.Property(ec => ec.IdCaracteristicaTipo)
                .HasColumnName("Cl_IdCaracteristicaTipo");

            builder.Property(ec => ec.IdCaracteristicaValor)
                .HasColumnName("Cl_IdCaracteristicaValor");

            #endregion Proprieties

            builder.HasOne(ec => ec.Equipamento)
                .WithMany(ec => ec.EquipamentoCaracteristicas)
                .HasForeignKey(ec => ec.IdEquipamento)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ec => ec.CaracteristicaTipo)
                .WithMany(ec => ec.EquipamentoCaracteristicas)
                .HasForeignKey(ec => ec.IdCaracteristicaTipo);

            builder.HasOne(ec => ec.CaracteristicaValor)
                .WithMany(ec => ec.EquipamentoCaracteristicas)
                .HasForeignKey(ec => ec.IdCaracteristicaValor);
        }
    }
}