using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Cliente : EntityBase
{
    public String Nome { get; set; }
    public bool RestricaoSerasa { get; set; }
    public Decimal RendaTotal { get; set; }

    //Relationship
    public virtual IEnumerable<Processo> Processos { get; set; }
    public virtual IEnumerable<Documento> Documentos { get; set; }
    public virtual IEnumerable<RendaCliente> RendaCliente { get; set; }
    public virtual IEnumerable<ContatoCliente> ContatoCliente { get; set; }
    public virtual IEnumerable<SituacaoCredito> SituacaoCredito { get; set; }
}
