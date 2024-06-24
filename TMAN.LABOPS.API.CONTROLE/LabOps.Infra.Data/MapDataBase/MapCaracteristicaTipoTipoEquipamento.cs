using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapCaracteristicaTipoTipoEquipamento : IEntityTypeConfiguration<CaracteristicaTipoTipoEquipamento>
    {
        public void Configure(EntityTypeBuilder<CaracteristicaTipoTipoEquipamento> builder)
        {
            builder.HasKey(ctte => new { ctte.CaracteristicaTipo_ID, ctte.TipoEquipamento_ID });

            builder.HasOne(ctte => ctte.CaracteristicaTipo)
                .WithMany(ct => ct.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.CaracteristicaTipo_ID);

            builder.HasOne(ctte => ctte.TipoEquipamento)
                .WithMany(te => te.CaracteristicaTipoTipoEquipamentos)
                .HasForeignKey(ctte => ctte.TipoEquipamento_ID);
        }
    }
}
