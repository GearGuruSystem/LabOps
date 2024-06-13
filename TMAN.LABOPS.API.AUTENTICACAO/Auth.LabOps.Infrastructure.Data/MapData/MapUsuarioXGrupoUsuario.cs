using Auth.LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.LabOps.Infrastructure.Data.MapData
{
    internal class MapUsuarioXGrupoUsuario : IEntityTypeConfiguration<UsuarioXGrupoUsuario>
    {
        public void Configure(EntityTypeBuilder<UsuarioXGrupoUsuario> builder)
        {
            builder.ToTable("UsuarioXGrupoUsuarios");
            builder.HasKey(ug => new { ug.IDUsuario, ug.IDGrupoUsuario });

            builder.HasOne(ug => ug.Usuario)
                .WithMany(u => u.UsuarioXGrupoUsuarios)
                .HasForeignKey(ug => ug.IDUsuario);

            builder.HasOne(ug => ug.GrupoUsuario)
                .WithMany(gu => gu.UsuarioXGrupoUsuarios)
                .HasForeignKey(ug => ug.IDGrupoUsuario);
        }
    }
}
