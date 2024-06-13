using Auth.LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Auth.LabOps.Infrastructure.Data.MapData
{
    internal class MapGrupoUsuarioXAplicacoes : IEntityTypeConfiguration<GrupoUsuarioXAplicacoes>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuarioXAplicacoes> builder)
        {
            builder.ToTable("GrupoUsuarioXAplicacoes");
            builder.HasKey(gua => new { gua.IDAplicacao, gua.IDGrupoUsuario });

            builder.Property(gua => gua.Permissao)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne(gua => gua.Aplicacao)
                .WithMany(a => a.GrupoUsuarioXAplicacoes)
                .HasForeignKey(gua => gua.IDAplicacao);

            builder.HasOne(gua => gua.GrupoUsuario)
                .WithMany(gu => gu.GrupoUsuarioXAplicacoes)
                .HasForeignKey(gua => gua.IDGrupoUsuario);
        }
    }
}
