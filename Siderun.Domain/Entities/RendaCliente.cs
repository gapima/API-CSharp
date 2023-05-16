using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class RendaCliente : EntityBase
{
    public decimal Renda { get; set; }
    public string TipoComprovante { get; set; }

    //Relationship
    public Guid ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
}
