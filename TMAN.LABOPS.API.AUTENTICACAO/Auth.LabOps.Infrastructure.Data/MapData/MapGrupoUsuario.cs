using Auth.LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.LabOps.Infrastructure.Data.MapData
{
    internal class MapGrupoUsuario : IEntityTypeConfiguration<GrupoUsuario>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuario> builder)
        {
            builder.ToTable("GrupoUsuarios");
            builder.HasKey(gu => gu.IDGrupoUsuario);

            builder.Property(gu => gu.Descricao)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(gu => gu.InseridoEm)
                .IsRequired();

            builder.Property(gu => gu.AtualizadoEm)
                .IsRequired();
        }
    }
}
