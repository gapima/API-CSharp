using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class ProcessoMap : IEntityTypeConfiguration<Processo>
{
    public void Configure(EntityTypeBuilder<Processo> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Produto);
        builder.Property(x => x.Estagio);
        builder.Property(x => x.ValorCompVenda);
        builder.Property(x => x.DataCriacao);
        builder.Property(x => x.DataAprovacao);
        builder.Property(x => x.ValorCredito);
        builder.Property(x => x.Observacao);
        builder.Property(x => x.DataVistoria);
        builder.Property(x => x.ContatoResponsavel);


    }
}
