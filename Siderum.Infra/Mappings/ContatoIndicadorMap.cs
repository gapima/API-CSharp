using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class ContatoIndicadorMap : IEntityTypeConfiguration<ContatoIndicador>
{
    public void Configure(EntityTypeBuilder<ContatoIndicador> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Tipo);
        builder.Property(x => x.Telefone);
        builder.Property(x => x.Email);
    }
}
