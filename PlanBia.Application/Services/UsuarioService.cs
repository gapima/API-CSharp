
using AutoMapper;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using Siderum.Infra.Interfaces;

namespace PlanBia.Application.Services;

partial class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<UsuarioDto>> Get()
    {
        var usuarioEntities = await _repository.Get();
        var usuarioDto = _mapper.Map<List<UsuarioDto>>(usuarioEntities);
        return usuarioDto;
    }

    public async Task<UsuarioDto> Get(Guid id)
    {
        var entity = await _repository.Get(id);
        var entityDto = _mapper.Map<UsuarioDto>(entity);
        return entityDto;
    }
    public async Task<UsuarioDtoFlat> Create(UsuarioDtoFlat obj)
    {
        var entity = _mapper.Map<Usuario>(obj);
        await _repository.Create(entity);
        obj.Id = entity.Id;
        return obj;
    }
    public async Task<UsuarioDtoFlat> Update(Guid id, UsuarioDtoFlat obj)
    {
        var entityExists = await _repository.Get(id);
        if (entityExists != null) 
        {
            var entity = _mapper.Map<Usuario>(obj);
            entity.Id = entityExists.Id;
            await _repository.Update(entity);
            obj.Id = entity.Id;
            return obj;
        }
        return obj;
    }
    public Task<bool> Delete(Guid id)
    {
        return _repository.Delete(id);
    }

}
