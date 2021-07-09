using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Core.Services
{
  public class FonteRecursoService : AbstractService, IFonteRecursoService
  {
    protected IFonteRecursoRepository Repository { get; set; }

    public FonteRecursoService(IFonteRecursoRepository repository)
    {
      ServiceType = typeof(FonteRecurso);
      Repository = repository;
    }

    public async Task<FonteRecurso> Get(int exercicio, string codigoPrincipal)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.CodigoPrincipal == codigoPrincipal);
    }

    public async Task<IEnumerable<FonteRecurso>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}