using Auth.LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auth.LabOps.Infrastructure.Data.MapData
{
    internal class MapAplicacao : IEntityTypeConfiguration<Aplicacao>
    {
        public void Configure(EntityTypeBuilder<Aplicacao> builder)
        {
            builder.ToTable("Aplicacoes");
            builder.HasKey(a => a.IDAplicacao);

            builder.Property(a => a.Descricao)
                .HasMaxLength(120)
                .IsRequired();
        }
    }
}
