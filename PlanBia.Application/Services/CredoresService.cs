using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class CredoresService : ICredoresService
{
    private readonly ICredoresRepository _repository;
    private readonly IMapper _mapper;

    public CredoresService(ICredoresRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<CredoresDto>> Get()
    {
        var credoresEntities = await _repository.Get();
        var credoresDto = _mapper.Map<List<CredoresDto>>(credoresEntities);
        return credoresDto;
    }

    public async Task<CredoresDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<CredoresDto>(entity);
        return entityDto;
    }
    public async Task<CredoresDtoFlat> Create(CredoresDtoFlat obj)
    {
        var entity = _mapper.Map<Credores>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;

        return obj;
    }

    public async Task<CredoresDtoFlat> Update(Guid id, CredoresDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<Credores>(obj);
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
