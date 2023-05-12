using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Processo : EntityBase
{
    public string Produto { get; set; }
    public string Estagio { get; set; }
    public decimal ValorCompVenda { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAprovacao { get; set; }
    public Decimal ValorCredito { get; set; }
    public string Observacao { get; set; }
    public DateTime DataVistoria { get; set; }
    public string ContatoResponsavel { get; set; }

    //Relationship
    public Guid UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    
    public Guid IndicadorId { get; set; }
    public virtual Indicador indicador { get; set; }

    public Guid ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
}
