using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Domain.Repositories
{
  public partial class AbstractRepository<T> : IAbstractRepository<T> where T : class
  {
    protected readonly OSContext Context;

    public AbstractRepository(IConfiguration configuration)
    {
      Context = new OSContext(configuration);
    }

    public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties)
    {
      var set = Context.Set<T>();
      foreach (var includeProperty in includeProperties)
      {
        set.Include(includeProperty);
      }

      return await set.SingleOrDefaultAsync(match);
    }

    public virtual async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties)
    {
      var set = Context.Set<T>();
      foreach (var includeProperty in includeProperties)
      {
        set.Include(includeProperty);
      }

      if (match != null)
        return await set.Where(match).ToListAsync<T>();

      return await set.ToListAsync<T>();
    }

    public virtual async Task<T> AddAsync(T t)
    {
      Context.Set<T>().Add(t);
      await Context.SaveChangesAsync();
      return t;
    }

    public virtual async Task<T> UpdateAsync(T t, object key)
    {
      if (t == null)
        return null;

      T exist = await Context.Set<T>().FindAsync(key);

      if (exist != null)
      {
        //TODO :: Rever log aqui.
        //string log = Newtonsoft.Json.JsonConvert.SerializeObject(exist);

        Context.Entry(exist).CurrentValues.SetValues(t);
        await Context.SaveChangesAsync();
      }
      return exist;
    }

    public async Task<int> CountAsync()
    {
      return await Context.Set<T>().CountAsync();
    }

    public virtual async Task<int> DeleteAsync(T entity)
    {
      Context.Set<T>().Remove(entity);
      return await Context.SaveChangesAsync();
    }

    public void Dispose()
    {
      Dispose(true);
      //GC.SuppressFinalize(this);
    }

    public async virtual Task<int> SaveAsync()
    {
      return await Context.SaveChangesAsync();
    }

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          Context.Dispose();
        }
        this.disposed = true;
      }
    }
  }
}