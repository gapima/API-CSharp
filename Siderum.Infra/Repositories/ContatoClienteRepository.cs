using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;

namespace Siderum.Infra.Repositories;

public class ContatoClienteRepository : BaseRepository<ContatoCliente>, IContatoClienteRepository
{
    public ContatoClienteRepository(SiderumContext context) : base(context)
    {
    }
}
