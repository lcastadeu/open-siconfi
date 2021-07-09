using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Application.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]/")]
  public class FonteRecursoController : AbstractController
  {
    protected IFonteRecursoService Service { get; set; }

    public FonteRecursoController(IFonteRecursoService service) 
      : base(service)
    {
      Service = service;
    }
    
    [HttpGet("{exercicio}/{codigoPrincipal}")]
    public async Task<OSMensagem> Get(int exercicio, string codigoPrincipal)
    {
      return new OSMensagem(await Service.Get(exercicio, codigoPrincipal));
    }

    [HttpGet("{exercicio}/")]
    public async Task<OSMensagem> GetAll(int exercicio)
    {
      return new OSMensagem(await Service.GetAll(exercicio));
    }

  }
}