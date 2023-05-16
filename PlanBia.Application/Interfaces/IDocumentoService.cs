
using PlanBia.Application.Dtos;

namespace PlanBia.Application.Interfaces;

public interface IDocumentoService
{
    Task<List<DocumentoDto>> Get();
    Task<DocumentoDto> Get(Guid id);
    Task<DocumentoDtoFlat> Create(DocumentoDtoFlat obj);
    Task<DocumentoDtoFlat> Update(Guid id, DocumentoDtoFlat obj);
    Task<bool> Delete(Guid id);
}
