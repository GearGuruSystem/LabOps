using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapEquipamento : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.HasKey(e => e.IDEquipamento);

            builder.HasOne(e => e.Fabricante)
                .WithMany()
                .HasForeignKey(e => e.IDFabricante);

            builder.HasOne(e => e.Laboratorio)
                .WithMany()
                .HasForeignKey(e => e.IDLaboratorio);

            builder.HasOne(e => e.Situacao)
                .WithMany()
                .HasForeignKey(e => e.IDSituacao);

            builder.HasOne(e => e.TipoEquipamento)
                .WithMany()
                .HasForeignKey(e => e.IDTipoEquipamento);
        }
    }
}
