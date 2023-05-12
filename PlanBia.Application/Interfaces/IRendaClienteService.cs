
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IRendaClienteService
{
    Task<List<RendaClienteDto>> Get();
    Task<RendaClienteDto> Get(Guid id);
    Task<RendaClienteDtoFlat> Create(RendaClienteDtoFlat obj);
    Task<RendaClienteDtoFlat> Update(Guid id, RendaClienteDtoFlat obj);
    Task<bool> Delete(Guid id);
}
