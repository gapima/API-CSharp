using Microsoft.EntityFrameworkCore;
using Siderum.Domain.Entities.Base;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;

namespace Siderum.Infra.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
{
    private readonly SiderumContext _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(SiderumContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<List<T>> Get()
    {
        var entities = await _dbSet.ToListAsync();
        return entities;
    }

    public async Task<T> Get(Guid id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));
        return entity;
    }

    public async Task<T> Create(T obj)
    {
        _dbSet.Add(obj);
        await _context.SaveChangesAsync();
        return obj;
    }

    public async Task<T> Update(T obj)
    {
        var oldEntity = await Get(obj.Id);

        _context.Entry(oldEntity).CurrentValues.SetValues(obj);
        await _context.SaveChangesAsync();

        return oldEntity;
    }

    public async Task<bool> Delete(Guid id)
    {
        var entity = await Get(id);

        if (entity == null)
            return false;

        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}