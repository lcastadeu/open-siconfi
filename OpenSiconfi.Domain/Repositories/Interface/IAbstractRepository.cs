using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OpenSiconfi.Domain.Repositories.Interface
{
  public partial interface IAbstractRepository<T> where T : class
  {
    Task<T> FindAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties);
    Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match, params Expression<Func<T, object>>[] includeProperties);
    Task<T> AddAsync(T t);
    Task<T> UpdateAsync(T t, object key);
    Task<int> CountAsync();
    Task<int> DeleteAsync(T entity);
    Task<int> SaveAsync();
    void Dispose();
  }
}