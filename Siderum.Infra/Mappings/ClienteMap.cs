using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class ClienteMap : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.RestricaoSerasa);
        builder.Property(x => x.RendaTotal);

        builder.HasMany(x => x.Processos).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Documentos).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.RendaCliente).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.ContatoCliente).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.SituacaoCredito).WithOne(x => x.Cliente).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
    }
}
