
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IProcessoService
{
    Task<List<ProcessoDto>> Get();
    Task<ProcessoDto> Get(Guid id);
    Task<ProcessoDtoFlat> Create(ProcessoDtoFlat obj);
    Task<ProcessoDtoFlat> Update(Guid id, ProcessoDtoFlat obj);
    Task<bool> Delete(Guid id);
}
