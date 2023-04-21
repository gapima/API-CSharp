using Siderum.Domain.Entities.Base;


namespace Siderum.Domain.Entities;

public class Indicador : EntityBase
{
    public String Nome { get; set; }

    //Relationship
    public virtual IEnumerable<ContatoIndicador> ContatoIndicador { get; set; }
    public virtual IEnumerable<Processo> Processos { get; set; }

}
