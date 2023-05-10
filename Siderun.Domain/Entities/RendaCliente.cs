using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class RendaCliente : EntityBase
{
    public Decimal Renda { get; set; }
    public String TipoComprovante { get; set; }

    //Relationship
    public Guid ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
}
