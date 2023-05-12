using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class GrupoMap : IEntityTypeConfiguration<Grupo>
{
    public void Configure(EntityTypeBuilder<Grupo> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Tipo);

        builder.HasMany(x => x.Usuarios).WithOne(x => x.Grupo).HasForeignKey(x => x.GrupoId).OnDelete(DeleteBehavior.Cascade);

    }
}
