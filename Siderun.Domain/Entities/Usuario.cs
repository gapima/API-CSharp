using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class Usuario : EntityBase
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    // Relacionamento
    public Guid GrupoId { get; set; }
    public virtual Grupo Grupo { get; set; }
}

