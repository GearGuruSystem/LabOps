using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    internal class ModelConfig : IEntityTypeConfiguration<ModelEquipament>
    {
        public void Configure(EntityTypeBuilder<ModelEquipament> builder)
        {
            builder.ToTable("TB_ModeloEquipamento");
            builder.HasKey(x => x.Id);
        }
    }
}
