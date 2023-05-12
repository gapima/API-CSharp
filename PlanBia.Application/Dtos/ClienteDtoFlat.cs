namespace PlanBia.Application.Dtos;

public class ClienteDtoFlat
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public bool RestricaoSerasa { get; set; }
    public decimal RendaTotal { get; set; }
}