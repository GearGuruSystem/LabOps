using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapCaracteristicaTipoTipoEquipamento : IEntityTypeConfiguration<CaracteristicaTipoTipoEquipamento>
    {
        public void Configure(EntityTypeBuilder<CaracteristicaTipoTipoEquipamento> builder)
        {
            builder.ToTable("Tb_CaracteristicaTipoTipoEquipamento");

            builder.HasKey(ctte => new { ctte.IdCaracteristicaTipo, ctte.IdTipoEquipamento });

            builder.HasOne(ctte => ctte.CaracteristicaTipo)
                .WithMany(ct => ct.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.IdCaracteristicaTipo);

            builder.HasOne(ctte => ctte.TipoEquipamento)
                .WithMany(te => te.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.IdTipoEquipamento);
        }
    }
}
