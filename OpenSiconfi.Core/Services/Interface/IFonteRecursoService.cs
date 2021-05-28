using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Entities.Interface;

namespace OpenSiconfi.Application.Services.Interface
{
  public partial interface IFonteRecursoService : IAbstractService
  {
    Task<IFonteRecursoModel> Get(int exercicio, string codigoPrincipal);
    Task<IEnumerable<IFonteRecursoModel>> GetAll(int exercicio);
  }
}