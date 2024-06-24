using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapTipoEquipamento : IEntityTypeConfiguration<TipoEquipamento>
    {
        public void Configure(EntityTypeBuilder<TipoEquipamento> builder)
        {
            builder.HasKey(te => te.IDTipoEquipamento);
        }
    }
}
