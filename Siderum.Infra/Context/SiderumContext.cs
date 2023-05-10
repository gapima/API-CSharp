using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities;

namespace Siderum.Infra.Context;

public class SiderumContext : DbContext
{
    public SiderumContext() { }
    public SiderumContext(DbContextOptions<SiderumContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ContatoCliente> ContatoClientes { get; set; }
    public DbSet<ContatoIndicador> ContatoIndicador { get; set; }
    public DbSet<Credores> Credores { get; set; }
    public DbSet<Documento> Documentos { get; set; }
    public DbSet<Grupo> Grupos { get; set; }
    public DbSet<Indicador> Indicador { get; set; }
    public DbSet<Processo> Processos { get; set; }
    public DbSet<RendaCliente> RendaCliente { get; set;}
    public DbSet<SituacaoCredito> SituacaoCredito { get; set; }
    public DbSet<TipoDocumento> TipoDocumento { get; set;}
    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SiderumContext).Assembly);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseSqlServer(SharedConstants.ConnectionString);
    }

}
