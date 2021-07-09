using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Entities.Interface;
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