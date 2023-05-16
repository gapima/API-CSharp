using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Siderum.Infra.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome);
        builder.Property(x => x.Email);
        builder.Property(x => x.Login);
        builder.Property(x => x.Senha);

        builder.HasMany(x => x.Processos).WithOne(x => x.Usuario).HasForeignKey(x => x.UsuarioId).OnDelete(DeleteBehavior.Cascade);

    }
}
