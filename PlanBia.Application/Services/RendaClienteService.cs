
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

partial class RendaClienteService : IRendaClienteService
{
    private readonly IRendaClienteRepository _repository;
    private readonly IMapper _mapper;

    public RendaClienteService(IRendaClienteRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RendaClienteDto>> Get()
    {
        var rendaClienteEntities = await _repository.Get();
        var rendaClienteDto = _mapper.Map<List<RendaClienteDto>>(rendaClienteEntities);
        return rendaClienteDto;
    }

    public async Task<RendaClienteDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<RendaClienteDto>(entity);
        return entityDto;
    }
    public async Task<RendaClienteDtoFlat> Create(RendaClienteDtoFlat obj)
    {
        var entity = _mapper.Map<RendaCliente>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<RendaClienteDtoFlat> Update(Guid id, RendaClienteDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<RendaCliente>(obj);
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
