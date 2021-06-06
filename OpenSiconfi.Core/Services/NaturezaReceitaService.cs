using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Application.Services
{
  public partial class NaturezaReceitaService : AbstractService, INaturezaReceitaService
  {
    protected INaturezaReceitaRepository Repository { get; set; }

    public NaturezaReceitaService(INaturezaReceitaRepository repository)
    {
      ServiceType = typeof(NaturezaReceita);
      Repository = repository;
    }

    public async Task<NaturezaReceita> Get(int exercicio, string contaReceita)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.NR == contaReceita);
    }

    public async Task<IEnumerable<NaturezaReceita>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}