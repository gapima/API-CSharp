
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class IndicadorService : IIndicadorService
{

    private readonly IIndicadorRepository _repository;
    private readonly IMapper _mapper;

    public IndicadorService(IIndicadorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<IndicadorDto>> Get()
    {
        var indicadorEntities = await _repository.Get();
        var indicadorDto = _mapper.Map<List<IndicadorDto>>(indicadorEntities);
        return indicadorDto;
    }

    public async Task<IndicadorDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<IndicadorDto>(entity);
        return entityDto;
    }
    public async Task<IndicadorDtoFlat> Create(IndicadorDtoFlat obj)
    {
        var entity = _mapper.Map<Indicador>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<IndicadorDtoFlat> Update(Guid id, IndicadorDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null)
        {
            var entity = _mapper.Map<Indicador>(obj);
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
