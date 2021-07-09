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
  public partial class InformacaoComplementarRepository : AbstractRepository<InformacaoComplementar>, IInformacaoComplementarRepository
  {
    public InformacaoComplementarRepository(IConfiguration configuration) : base(configuration)
    {

    }
  }
}