using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Siderum.Infra.Mappings;

public class SituacaoCreditoMap : IEntityTypeConfiguration<SituacaoCredito>
{
    public void Configure(EntityTypeBuilder<SituacaoCredito> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.IsValid);

        //builder.HasMany(x => x.Credores).WithOne(x => x.SituacaoCredito).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
    }
}
