using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    internal class EquipamentConfig : IEntityTypeConfiguration<Equipament>
    {
        public void Configure(EntityTypeBuilder<Equipament> builder)
        {
            builder.ToTable("TB_Equipamento");
            builder.HasKey(x => x.Id);

        }
    }
}
