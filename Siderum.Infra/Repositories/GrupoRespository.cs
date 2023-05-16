using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;

namespace Siderum.Infra.Repositories;

public class GrupoRespository : BaseRepository<Grupo>, IGrupoRepository
{
    public GrupoRespository(SiderumContext context) : base(context)
    {
    }
}
