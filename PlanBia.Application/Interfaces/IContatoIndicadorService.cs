
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IContatoIndicadorService
{
    Task<List<ContatoIndicadorDto>> Get();
    Task<ContatoIndicadorDto> Get(Guid id);
    Task<ContatoIndicadorDtoFlat> Create(ContatoIndicadorDtoFlat obj);
    Task<ContatoIndicadorDtoFlat> Update(Guid id, ContatoIndicadorDtoFlat obj);
    Task<bool> Delete(Guid id);
}
