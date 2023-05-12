using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IClienteService
{
    Task<List<ClienteDto>> Get();
    Task<ClienteDto> Get(Guid id);
    Task<ClienteDtoFlat> Create(ClienteDtoFlat obj);
    Task<ClienteDtoFlat> Update(Guid id, ClienteDtoFlat obj);
    Task<bool> Delete(Guid id);
}
