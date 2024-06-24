using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapLaboratorio : IEntityTypeConfiguration<Laboratorio>
    {
        public void Configure(EntityTypeBuilder<Laboratorio> builder)
        {
            builder.HasKey(l => l.IDLaboratorio);
        }
    }
}
