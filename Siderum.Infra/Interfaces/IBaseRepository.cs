using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Siderum.Domain.Entities;
using Siderum.Domain.Entities.Base;

namespace Siderum.Infra.Interfaces;

public interface IBaseRepository<T> where T : EntityBase
{
    Task<List<T>> Get();
    Task<T> Get(Guid id);
    Task<T> Create(T obj);
    Task<T> Update(T obj);
    Task<bool> Delete(Guid id);
}
