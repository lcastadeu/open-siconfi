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
  [Route("api/v1/[controller]/")]
  public class InformacaoComplementarController : AbstractController
  {
    protected IInformacaoComplementarService Service { get; set; }

    public InformacaoComplementarController(IInformacaoComplementarService service)
      : base(service)
    {
      Service = service;
    }

    [HttpGet("{exercicio}/{codigoIC}")]
    public async Task<OSMensagem> Get(int exercicio, string codigoIC)
    {
      return new OSMensagem(await Service.Get(exercicio, codigoIC));
    }

    [HttpGet("{exercicio}/")]
    public async Task<OSMensagem> GetAll(int exercicio)
    {
      return new OSMensagem(await Service.GetAll(exercicio));
    }
  }
}