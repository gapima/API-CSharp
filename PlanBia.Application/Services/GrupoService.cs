

using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class GrupoService : IGrupoService
{
    private readonly IGrupoRepository _repository;
    private readonly IMapper _mapper;

    public GrupoService(IGrupoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GrupoDto>> Get()
    {
        var grupoEntities = await _repository.Get();
        var grupoDto = _mapper.Map<List<GrupoDto>>(grupoEntities);
        return grupoDto;
    }

    public async Task<GrupoDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<GrupoDto>(entity);
        return entityDto;
    }

    public async Task<GrupoDtoFlat> Create(GrupoDtoFlat obj)
    {
        var entity = _mapper.Map<Grupo>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<GrupoDtoFlat> Update(Guid id, GrupoDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null)
        {
            var entity = _mapper.Map<Grupo>(obj);
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
