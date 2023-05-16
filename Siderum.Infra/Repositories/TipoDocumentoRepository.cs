using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;


namespace Siderum.Infra.Repositories;

public class TipoDocumentoRepository : BaseRepository<TipoDocumento>, ITipoDocumentoRepository
{
    public TipoDocumentoRepository(SiderumContext context) : base(context)
    {
    }
}
