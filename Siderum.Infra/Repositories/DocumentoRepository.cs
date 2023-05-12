using Siderum.Domain.Entities;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;


namespace Siderum.Infra.Repositories;

public class DocumentoRepository : BaseRepository<Documento>, IDocumentoRepository
{
    public DocumentoRepository(SiderumContext context) : base(context)
    {
    }
}
