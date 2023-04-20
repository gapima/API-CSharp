using Siderum.Domain.Entities.Base;


namespace Siderum.Domain.Entities;

public class ContatoIndicador : EntityBase
{
    public string Tipo { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    //Relacionamento
    public Guid IndicadorId  { get; set; }
    public virtual Indicador Indicador { get; set; }
}
