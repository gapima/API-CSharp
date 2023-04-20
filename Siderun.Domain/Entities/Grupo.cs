using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Grupo : EntityBase
{
    public string Tipos { get; set; }

    // Relacionamento
    public virtual IEnumerable<Usuario> Usuarios { get; set; }
}
