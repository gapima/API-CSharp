using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Siderum.Infra.Mappings;

public class DocumentoMap : IEntityTypeConfiguration<Documento>
{
    public void Configure(EntityTypeBuilder<Documento> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Numero);
        builder.Property(x => x.Digito);
        builder.Property(x => x.Expiracao);
    }
}
