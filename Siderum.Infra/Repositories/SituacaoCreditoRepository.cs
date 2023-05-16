using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;


namespace Siderum.Infra.Repositories;

public class SituacaoCreditoRepository : BaseRepository<SituacaoCredito>, ISituacaoCreditoRepository
{
    public SituacaoCreditoRepository(SiderumContext context) : base(context)
    {
    }
}
