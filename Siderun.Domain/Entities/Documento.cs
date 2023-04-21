using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Documento : EntityBase
{
    public string Numero { get; set; }
    public string Digito { get; set; }
    public DateTime Expiracao { get; set; }

    //RelationShip
    public Guid TipoDocumentoId { get; set; }
    public virtual TipoDocumento tipoDocumento { get; set; }

    public Guid ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
}
