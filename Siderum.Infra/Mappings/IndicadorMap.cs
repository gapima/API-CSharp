using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Siderum.Infra.Mappings;

public class IndicadorMap : IEntityTypeConfiguration<Indicador>
{
    public void Configure(EntityTypeBuilder<Indicador> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome);

        builder.HasMany(x => x.ContatoIndicador).WithOne(x => x.Indicador).HasForeignKey(x => x.IndicadorId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Processos).WithOne(x => x.indicador).HasForeignKey(x => x.IndicadorId).OnDelete(DeleteBehavior.Cascade);

    }
}
