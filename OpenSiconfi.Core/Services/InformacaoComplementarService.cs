using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Core.Services
{
  public class InformacaoComplementarService : AbstractService, IInformacaoComplementarService
  {
    protected IInformacaoComplementarRepository Repository { get; set; }

    public InformacaoComplementarService(IInformacaoComplementarRepository repository)
    {
      ServiceType = typeof(InformacaoComplementar);
      Repository = repository;
    }

    public async Task<InformacaoComplementar> Get(int exercicio, string codigoIC)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.CodigoIC.ToUpper().Equals(codigoIC.ToUpper()));
    }

    public async Task<IEnumerable<InformacaoComplementar>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}