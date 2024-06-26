using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapCaracteristicaValor : IEntityTypeConfiguration<CaracteristicaValor>
    {
        public void Configure(EntityTypeBuilder<CaracteristicaValor> builder)
        {
            builder.ToTable("Tb_CaracteristicaValor");
            builder.HasKey(cv => cv.Id);
        }
    }
}
