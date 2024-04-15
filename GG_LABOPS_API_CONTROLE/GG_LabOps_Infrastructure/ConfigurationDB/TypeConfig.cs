using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    internal class TypeConfig : IEntityTypeConfiguration<TypeEquipament>
    {
        public void Configure(EntityTypeBuilder<TypeEquipament> builder)
        {
            builder.ToTable("TB_TipoEquipamento");
            builder.HasKey(x => x.Id);
        }
    }
}
