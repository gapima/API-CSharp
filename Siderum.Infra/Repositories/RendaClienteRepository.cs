using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;

namespace Siderum.Infra.Repositories;

public class RendaClienteRepository : BaseRepository<RendaCliente>, IRendaClienteRepository
{
    public RendaClienteRepository(SiderumContext context) : base(context)
    {
    }
}
