using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Entities.Interface;

namespace OpenSiconfi.Application.Services.Interface
{
  public partial interface IInformacaoComplementarService : IAbstractService
  {
    Task<IInformacaoComplementar> Get(int exercicio, string codigoIC);
    Task<IEnumerable<IInformacaoComplementar>> GetAll(int exercicio);
  }
}