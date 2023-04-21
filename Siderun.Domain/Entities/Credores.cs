using Siderum.Domain.Entities.Base;
namespace Siderum.Domain.Entities;

public class Credores : EntityBase
{
    public string Nome { get; set; }

    //Relationship
    public virtual IEnumerable<SituacaoCredito> SituacaoCredito { get; set; }
}
