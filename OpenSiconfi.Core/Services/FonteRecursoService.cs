using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Entities.Interface;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Application.Services
{
  public partial class FonteRecursoService : AbstractService, IFonteRecursoService
  {
    protected IFonteRecursoRepository Repository { get; set; }

    public FonteRecursoService(IFonteRecursoRepository repository)
    {
      ServiceType = typeof(FonteRecurso);
      Repository = repository;
    }

    public async Task<IFonteRecurso> Get(int exercicio, string codigoPrincipal)
    {
      return await Repository.FindAsync(x => x.Exercicio == exercicio && x.CodigoPrincipal == codigoPrincipal);
    }

    public async Task<IEnumerable<IFonteRecurso>> GetAll(int exercicio)
    {
      return await Repository.FindAllAsync(x => x.Exercicio == exercicio);
    }
  }
}