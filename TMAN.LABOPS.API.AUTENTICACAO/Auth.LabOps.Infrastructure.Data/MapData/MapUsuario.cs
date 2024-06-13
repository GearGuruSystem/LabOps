using Auth.LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.LabOps.Infrastructure.Data.MapData
{
    internal class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(u => u.IDUsuario);

            builder.Property(u => u.Login)
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.InseridoEm)
                .IsRequired();

            builder.Property(u => u.AtualizadoEm)
                .IsRequired();

            builder.Ignore(u => u.Token);
        }
    }
}
