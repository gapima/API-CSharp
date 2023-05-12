using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;


namespace Siderum.Infra.Repositories;

public class IndicadorRepository : BaseRepository<Indicador>, IIdicadorRepository
{
    public IndicadorRepository(SiderumContext context) : base(context)
    {
    }
}
