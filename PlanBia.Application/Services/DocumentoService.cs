
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class DocumentoService : IDocumentoService
{
    private readonly IDocumentoRepository _repository;
    private readonly IMapper _mapper;

    public DocumentoService(IDocumentoRepository repository, IMapper mapper)
    {
        _repository = repository; 
        _mapper = mapper;
    }
    public async Task<List<DocumentoDto>> Get()
    {
        var documentoEntities = await _repository.Get();
        var documentoDto = _mapper.Map<List<DocumentoDto>>(documentoEntities);
        return documentoDto;
    }

    public async Task<DocumentoDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<DocumentoDto>(entity);
        return entityDto;
    }
    public async Task<DocumentoDtoFlat> Create(DocumentoDtoFlat obj)
    {
        var entity = _mapper.Map<Documento>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<DocumentoDtoFlat> Update(Guid id, DocumentoDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null)
        {
            var entity = _mapper.Map<Documento>(obj);
            entity.Id = entityExists.Id;
            await _repository.Update(entity);
            obj.Id = entity.Id;
            return obj;
        }
        return obj;
    }
    public async Task<bool> Delete(Guid id)
    {
        return await _repository.Delete(id);
    }


}
