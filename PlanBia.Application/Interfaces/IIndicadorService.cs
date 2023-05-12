using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IIndicadorService
{
    Task<List<IndicadorDto>> Get();
    Task<IndicadorDto> Get(Guid id);
    Task<IndicadorDtoFlat> Create(IndicadorDtoFlat obj);
    Task<IndicadorDtoFlat> Update(Guid id, IndicadorDtoFlat obj);
    Task<bool> Delete(Guid id);
}
