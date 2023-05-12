
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface ISituacaoCreditoService
{
    Task<List<SituacaoCreditoDto>> Get();
    Task<SituacaoCreditoDto> Get(Guid id);
    Task<SituacaoCreditoDtoFlat> Create(SituacaoCreditoDtoFlat obj);
    Task<SituacaoCreditoDtoFlat> Update(Guid id, SituacaoCreditoDtoFlat obj);
    Task<bool> Delete(Guid id);
}
