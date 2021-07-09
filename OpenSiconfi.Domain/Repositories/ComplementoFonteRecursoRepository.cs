using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Domain.Repositories
{
  public partial class ComplementoFonteRecursoRepository : AbstractRepository<ComplementoFonteRecurso>, IComplementoFonteRecursoRepository
  {
    public ComplementoFonteRecursoRepository(IConfiguration configuration) : base(configuration)
    {

    }
  }
}