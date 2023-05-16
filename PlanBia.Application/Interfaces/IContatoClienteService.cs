using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IContatoClienteService
{
    Task<List<ContatoClienteDto>> Get();
    Task<ContatoClienteDto> Get(Guid id);
    Task<ContatoClienteDtoFlat> Create(ContatoClienteDtoFlat obj);
    Task<ContatoClienteDtoFlat> Update(Guid id, ContatoClienteDtoFlat obj);
    Task<bool> Delete(Guid id);
}
