using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Application.Services.Interface
{
  public partial interface INaturezaReceitaService : IAbstractService
  {
    Task<NaturezaReceita> Get(int exercicio, string nr);
    Task<IEnumerable<NaturezaReceita>> GetAll(int exercicio);
  }
}