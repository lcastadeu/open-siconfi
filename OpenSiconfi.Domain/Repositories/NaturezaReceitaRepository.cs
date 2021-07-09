using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Domain.Repositories
{
  public partial class NaturezaReceitaRepository : AbstractRepository<NaturezaReceita>, INaturezaReceitaRepository
  {
    public NaturezaReceitaRepository(IConfiguration configuration) : base(configuration)
    {

    }
  }
}