using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class ContatoClienteMap : IEntityTypeConfiguration<ContatoCliente>
{
    public void Configure(EntityTypeBuilder<ContatoCliente> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Tipo);
        builder.Property(x => x.Telefone);
        builder.Property(x => x.Email);

        //builder.HasOne(x => x.ClienteId).WithOne(x => x).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);

    }

}
