

namespace PlanBia.Application.Dtos;

public class DocumentoDtoFlat
{
    public Guid Id { get; set; }
    public string Numero { get; set; }
    public string Digito { get; set; }
    public DateTime Expiracao { get; set; }
}
