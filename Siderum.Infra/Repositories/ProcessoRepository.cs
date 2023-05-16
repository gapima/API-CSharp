using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;


namespace Siderum.Infra.Repositories;

public class ProcessoRepository : BaseRepository<Processo>, IProcessoRepository
{
    public ProcessoRepository(SiderumContext context) : base(context)
    {
    }
}
