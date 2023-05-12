using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using AutoMapper;

namespace PlanBia.Application.Services;

public class ContatoClienteService : IContatoClienteService
{
    private readonly IContatoClienteRepository _repository;
    private readonly IMapper _mapper;

    public ContatoClienteService(IContatoClienteRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ContatoClienteDto>> Get()
    {
        var contatoClienteEntities = await _repository.Get();
        var contatoClienteDto = _mapper.Map<List<ContatoClienteDto>>(contatoClienteEntities);
        return contatoClienteDto;
    }

    public async Task<ContatoClienteDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<ContatoClienteDto>(entity);
        return entityDto;
    }
    public async Task<ContatoClienteDtoFlat> Create(ContatoClienteDtoFlat obj)
    {
        var entity = _mapper.Map<ContatoCliente>(obj);
        await _repository.Create(entity);

        obj.Id = entity.Id;
        return obj;
    }
    public async Task<ContatoClienteDtoFlat> Update(Guid id, ContatoClienteDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if(entityExists != null) 
        {
            var entity = _mapper.Map<ContatoCliente>(obj);
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
