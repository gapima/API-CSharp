using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;

namespace Siderum.Infra.Repositories;

public class ContatoIndicadorRepository : BaseRepository<ContatoIndicador>, IContatoIndicadorRepository
{
    public ContatoIndicadorRepository(SiderumContext context) : base(context)
    {
    }
}
