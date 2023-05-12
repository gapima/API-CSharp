
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IUsuarioService
{
    Task<List<UsuarioDto>> Get();
    Task<UsuarioDto> Get(Guid id);
    Task<UsuarioDtoFlat> Create(UsuarioDtoFlat obj);
    Task<UsuarioDtoFlat> Update(Guid id, UsuarioDtoFlat obj);
    Task<bool> Delete(Guid id);
}
