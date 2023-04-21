using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Grupo : EntityBase
{
    public string Tipo { get; set; }

    // Relationship
    public virtual IEnumerable<Usuario> Usuarios { get; set; }
}
