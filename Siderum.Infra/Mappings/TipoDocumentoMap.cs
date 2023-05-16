using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Siderum.Infra.Mappings;

public class TipoDocumentoMap : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Tipo);

        builder.HasMany(x => x.Documentos).WithOne(x => x.tipoDocumento).HasForeignKey(x => x.TipoDocumentoId).OnDelete(DeleteBehavior.Cascade);

    }
}
