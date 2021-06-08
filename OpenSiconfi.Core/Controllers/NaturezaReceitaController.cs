using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Application.Controllers
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]/")]
  public class NaturezaReceitaController : AbstractController
  {
    protected INaturezaReceitaService Service { get; set; }

    public NaturezaReceitaController(INaturezaReceitaService service)
      : base(service)
    {
      Service = service;
    }

    [HttpGet("{exercicio}/{nr}")]
    public async Task<OSMensagem> Get(int exercicio, string nr)
    {
      return new OSMensagem(await Service.Get(exercicio, nr));
    }

    [HttpGet("{exercicio}/")]
    public async Task<OSMensagem> GetAll(int exercicio)
    {
      return new OSMensagem(await Service.GetAll(exercicio));
    }
  }
}