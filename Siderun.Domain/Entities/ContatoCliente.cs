using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class ContatoCliente : EntityBase
{
    public string Tipo { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    //Relationship
    public Guid ClienteId { get; set; }
    public virtual Cliente cliente { get; set; }
}
