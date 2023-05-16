

using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class TipoDocumentoService : ITipoDocumentoService
{
    private readonly ITipoDocumentoRepository _repository;
    private readonly IMapper _mapper;

    public TipoDocumentoService(ITipoDocumentoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<TipoDocumentoDto>> Get()
    {
        var tipoDocumentoEntities = await _repository.Get();
        var tipoDocumentoDto = _mapper.Map<List<TipoDocumentoDto>>(tipoDocumentoEntities);
        return tipoDocumentoDto;
    }

    public async Task<TipoDocumentoDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<TipoDocumentoDto>(entity);
        return entityDto;
    }
    public async Task<TipoDocumentoDtoFlat> Create(TipoDocumentoDtoFlat obj)
    {
        var entity = _mapper.Map<TipoDocumento>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<TipoDocumentoDtoFlat> Update(Guid id, TipoDocumentoDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<TipoDocumento>(obj);
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
