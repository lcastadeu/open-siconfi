using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Application.Controllers;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Core.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]/")]
  public class ComplementoFonteRecursoController : AbstractController
  {
    protected IComplementoFonteRecursoService Service { get; set; }

    public ComplementoFonteRecursoController(IComplementoFonteRecursoService service)
      : base(service)
    {
      Service = service;
    }

    [HttpGet("{exercicio}/{codigo}")]
    public async Task<OSMensagem> Get(int exercicio, int codigo)
    {
      return new OSMensagem(await Service.Get(exercicio, codigo));
    }

    [HttpGet("{exercicio}/")]
    public async Task<OSMensagem> GetAll(int exercicio)
    {
      return new OSMensagem(await Service.GetAll(exercicio));
    }

  }
}