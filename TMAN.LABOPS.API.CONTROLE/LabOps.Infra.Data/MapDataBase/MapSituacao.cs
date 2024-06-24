using LabOps.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabOps.Infra.Data.MapDataBase
{
    internal class MapSituacao : IEntityTypeConfiguration<Situacao>
    {
        public void Configure(EntityTypeBuilder<Situacao> builder)
        {
            builder.HasKey(s => s.IDSituacao);
        }
    }
}
