using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    internal class LaboratoryConfig : IEntityTypeConfiguration<Laboratory>
    {
        public void Configure(EntityTypeBuilder<Laboratory> builder)
        {
            builder.ToTable("TB_Laboratory");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.BrandEquipament)
                .WithMany(y => y.Laboratory)
                .HasForeignKey(z => z.BrandEquipamentId);
        }
    }
}
