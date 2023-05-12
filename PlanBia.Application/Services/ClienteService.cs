using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClienteDto>> Get()
    {
        var clienteEntities = await _repository.Get();
        var clientesDto = _mapper.Map<List<ClienteDto>>(clienteEntities);
        return clientesDto;
    }

    public async Task<ClienteDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<ClienteDto>(entity);
        return entityDto;
    }

    public async Task<ClienteDtoFlat> Create(ClienteDtoFlat obj)
    {
        var entity = _mapper.Map<Cliente>(obj);
        await _repository.Create(entity);

        obj.Id = entity.Id;

        return obj;
    }

    public async Task<ClienteDtoFlat> Update(Guid id, ClienteDtoFlat obj)
    {

        var entityExists = await _repository.Get(id);

        if(entityExists != null)
        {
            var entity = _mapper.Map<Cliente>(obj);

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