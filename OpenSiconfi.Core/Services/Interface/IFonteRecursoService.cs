using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Core.Services.Interface
{
  public interface IFonteRecursoService : IAbstractService
  {
    Task<FonteRecurso> Get(int exercicio, string codigoPrincipal);
    Task<IEnumerable<FonteRecurso>> GetAll(int exercicio);
  }
}