using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Core.Services
{
  public class NaturezaReceitaService : AbstractService, INaturezaReceitaService
  {
    protected INaturezaReceitaRepository Repository { get; set; }

    public NaturezaReceitaService(INaturezaReceitaRepository repository)
    {
      ServiceType = typeof(NaturezaReceita);
      Repository = repository;
    }

    public async Task<NaturezaReceita> Get(int exercicio, string nr)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.NR == nr);
    }

    public async Task<IEnumerable<NaturezaReceita>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}