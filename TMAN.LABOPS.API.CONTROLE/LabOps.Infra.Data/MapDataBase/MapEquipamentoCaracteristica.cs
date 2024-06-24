using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapEquipamentoCaracteristica : IEntityTypeConfiguration<EquipamentoCaracteristica>
    {
        public void Configure(EntityTypeBuilder<EquipamentoCaracteristica> builder)
        {
            builder.HasKey(ec => ec.IDEquipamentoCaracteristica);

            builder.HasOne(ec => ec.CaracteristicaTipo)
                .WithMany()
                .HasForeignKey(ec => ec.IDCaracteristicaTipo);

            builder.HasOne(ec => ec.CaracteristicaValor)
                .WithMany()
                .HasForeignKey(ec => ec.IDCaracteristicaValor);
        }
    }
}
