

using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface ICredoresService
{
    Task<List<CredoresDto>> Get();
    Task<CredoresDto> Get(Guid id);
    Task<CredoresDtoFlat> Create(CredoresDtoFlat obj);
    Task<CredoresDtoFlat> Update(Guid id, CredoresDtoFlat obj);
    Task<bool> Delete(Guid id);
}
