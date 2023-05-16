
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class ContatoIndicadorService : IContatoIndicadorService
{
    private readonly IContatoIndicadorRepository _repository;
    private readonly IMapper _mapper;

    public ContatoIndicadorService(IContatoIndicadorRepository repository, IMapper mapper) 
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<List<ContatoIndicadorDto>> Get()
    {
        var contatoIndicadorEntities = await _repository.Get();
        var contatoIndicadorDto = _mapper.Map<List<ContatoIndicadorDto>>(contatoIndicadorEntities);
        return contatoIndicadorDto;
    }

    public async Task<ContatoIndicadorDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<ContatoIndicadorDto>(entity);
        return entityDto;
    }

    public async Task<ContatoIndicadorDtoFlat> Create(ContatoIndicadorDtoFlat obj)
    {
        var entity = _mapper.Map<ContatoIndicador>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }

    public async Task<ContatoIndicadorDtoFlat> Update(Guid id, ContatoIndicadorDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<ContatoIndicador>(obj);
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
