using System.Collections.Generic;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Application.Services
{
    public partial class NaturezaReceitaService : AbstractService, INaturezaReceitaService
    {
        public NaturezaReceitaService()
        {
            ServiceType = typeof(NaturezaReceita);
        }
    }
}