

namespace PlanBia.Application.Dtos;

public class ProcessoDto
{
    public Guid Id { get; set; }
    public string Produto { get; set; }
    public string Estagio { get; set; }
    public decimal ValorCompVenda { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAprovacao { get; set; }
    public decimal ValorCredito { get; set; }
    public string Observacao { get; set; }
    public DateTime DataVistoria { get; set; }
    public string ContatoResponsavel { get; set; }
}
