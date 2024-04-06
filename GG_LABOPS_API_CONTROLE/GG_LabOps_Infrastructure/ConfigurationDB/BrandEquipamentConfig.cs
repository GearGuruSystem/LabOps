﻿using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG_LabOps_Infrastructure.ConfigurationDB
{
    public class BrandEquipamentConfig : IEntityTypeConfiguration<BrandEquipament>
    {
        public void Configure(EntityTypeBuilder<BrandEquipament> builder)
        {
            builder.ToTable("TB_Brand_Equipament");
            builder.HasKey(x => x.Id);
        }
    }
}
