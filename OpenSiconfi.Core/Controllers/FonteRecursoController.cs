using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Application.Controllers
{
  [ApiController]
  [ApiVersion("1.0")]
  [Route("api/v{version:apiVersion}/{exercicio}/[controller]/")]
  public class FonteRecursoController : AbstractController
  {
    protected IFonteRecursoService Service { get; set; }

    public FonteRecursoController(IFonteRecursoService service) 
      : base(service)
    {
      Service = service;
    }

    [HttpGet("{codigoPrincipal}")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<OSMensagem> Get(int exercicio, string codigoPrincipal)
    {
      return new OSMensagem(await Service.Get(exercicio, codigoPrincipal));
    }

    [HttpGet]
    public async Task<OSMensagem> GetAll(int exercicio)
    {
      return new OSMensagem(await Service.GetAll(exercicio));
    }

  }
}