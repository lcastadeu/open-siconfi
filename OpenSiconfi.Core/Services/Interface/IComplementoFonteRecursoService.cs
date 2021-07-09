using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Core.Services.Interface
{
  public interface IComplementoFonteRecursoService : IAbstractService
  {
    Task<ComplementoFonteRecurso> Get(int exercicio, int codigo);
    Task<IEnumerable<ComplementoFonteRecurso>> GetAll(int exercicio);
  }
}