using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapCaracteristicaTipo : IEntityTypeConfiguration<CaracteristicaTipo>
    {
        public void Configure(EntityTypeBuilder<CaracteristicaTipo> builder)
        {
            builder.ToTable("Tb_CaracteristicaTipo");
            builder.HasKey(ct => ct.Id);
        }
    }
}
