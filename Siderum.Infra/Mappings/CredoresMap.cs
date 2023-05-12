using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class CredoresMap : IEntityTypeConfiguration<Credores>
{
    public void Configure(EntityTypeBuilder<Credores> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome);

       builder.HasMany(x => x.SituacaoCredito).WithOne(x => x.Credor).HasForeignKey(x => x.CredorId).OnDelete(DeleteBehavior.Cascade);
    }
}
