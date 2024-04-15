using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    public class BrandConfig : IEntityTypeConfiguration<BrandEquipament>
    {
        public void Configure(EntityTypeBuilder<BrandEquipament> builder)
        {
            builder.ToTable("TB_MarcaEquipamento");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BrandName).HasMaxLength(50);
        }
    }
}
