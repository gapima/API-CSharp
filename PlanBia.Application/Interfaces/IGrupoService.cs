
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IGrupoService
{
    Task<List<GrupoDto>> Get();
    Task<GrupoDto> Get(Guid id);
    Task<GrupoDtoFlat> Create(GrupoDtoFlat obj);
    Task<GrupoDtoFlat> Update(Guid id, GrupoDtoFlat obj);
    Task<bool> Delete(Guid id);
}
