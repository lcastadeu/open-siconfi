using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Entities.Interface;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Application.Services
{
  public partial class InformacaoComplementarService : AbstractService, IInformacaoComplementarService
  {
    protected IInformacaoComplementarRepository Repository { get; set; }

    public InformacaoComplementarService(IInformacaoComplementarRepository repository)
    {
      ServiceType = typeof(InformacaoComplementar);
      Repository = repository;
    }

    public async Task<IInformacaoComplementar> Get(int exercicio, string codigoIC)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.CodigoIC.ToUpper().Equals(codigoIC.ToUpper()));
    }

    public async Task<IEnumerable<IInformacaoComplementar>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}