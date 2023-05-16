
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class ProcessoService : IProcessoService
{
    private readonly IProcessoRepository _repository;
    private readonly IMapper _mapper;

    public ProcessoService(IProcessoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProcessoDto>> Get()
    {
        var processoEntities = await _repository.Get();
        var processoDto = _mapper.Map<List<ProcessoDto>>(processoEntities);
        return processoDto;
    }

    public async Task<ProcessoDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<ProcessoDto>(entity);
        return entityDto;
    }
    public async Task<ProcessoDtoFlat> Create(ProcessoDtoFlat obj)
    {
        var entity = _mapper.Map<Processo>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<ProcessoDtoFlat> Update(Guid id, ProcessoDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<Processo>(obj);
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
