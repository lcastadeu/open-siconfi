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
  public class FonteRecursoController : AbstractController
  {
    protected readonly IFonteRecursoService service;
    public FonteRecursoController(IFonteRecursoService service)
    {
      this.service = service;
    }

    [HttpGet]
    [Route("/")]
    public async Task<OSMensagem> Index(int exercicio){
      return new OSMensagem(await this.service.GetAll(exercicio));
    } 
  }
}