using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class TipoDocumento : EntityBase
{
    public string Tipo { get; set; }

    //Relationship
    public virtual IEnumerable<Documento> Documentos { get; set; }
}
