using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Core.Services
{
  public class ComplementoFonteRecursoService : AbstractService, IComplementoFonteRecursoService
  {
    protected IComplementoFonteRecursoRepository Repository { get; set; }

    public ComplementoFonteRecursoService(IComplementoFonteRecursoRepository repository)
    {
      ServiceType = typeof(ComplementoFonteRecurso);
      Repository = repository;
    }

    public async Task<ComplementoFonteRecurso> Get(int exercicio, int codigo)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.Codigo == codigo);
    }

    public async Task<IEnumerable<ComplementoFonteRecurso>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}