using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class RendaClienteMap : IEntityTypeConfiguration<RendaCliente>
{
    public void Configure(EntityTypeBuilder<RendaCliente> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Renda);
        builder.Property(x => x.TipoComprovante);
    }
}
