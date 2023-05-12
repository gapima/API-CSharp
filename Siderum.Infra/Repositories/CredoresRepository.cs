using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;
namespace Siderum.Infra.Repositories;

public class CredoresRepository : BaseRepository<Credores>, ICredoresRepository
{
    public CredoresRepository(SiderumContext context) : base(context)
    {
    }
}
