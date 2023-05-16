using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface ITipoDocumentoService
{
    Task<List<TipoDocumentoDto>> Get();
    Task<TipoDocumentoDto> Get(Guid id);
    Task<TipoDocumentoDtoFlat> Create(TipoDocumentoDtoFlat obj);
    Task<TipoDocumentoDtoFlat> Update(Guid id, TipoDocumentoDtoFlat obj);
    Task<bool> Delete(Guid id);
}
