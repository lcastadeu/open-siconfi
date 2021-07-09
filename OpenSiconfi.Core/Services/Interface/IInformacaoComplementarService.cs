using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Core.Services.Interface
{
  public interface IInformacaoComplementarService : IAbstractService
  {
    Task<InformacaoComplementar> Get(int exercicio, string codigoIC);
    Task<IEnumerable<InformacaoComplementar>> GetAll(int exercicio);
  }
}