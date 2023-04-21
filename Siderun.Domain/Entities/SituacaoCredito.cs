﻿using Siderum.Domain.Entities.Base;

namespace Siderum.Domain.Entities;

public class SituacaoCredito : EntityBase
{
    public bool IsValid { get; set; }

    //relationship
    public Guid ClienteId { get; set; }
    public virtual Cliente cliente { get; set; }

    public Guid CredorId { get; set; }
    public virtual IEnumerable<Credores> Credores { get; set; }
}
