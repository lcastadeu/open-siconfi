using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Domain.Repositories
{
  public partial class FonteRecursoRepository : AbstractRepository<FonteRecurso>, IFonteRecursoRepository
  {
    public FonteRecursoRepository(IConfiguration configuration) : base(configuration)
    {

    }
  }
}