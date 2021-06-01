using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Infrastructure;
using OpenSiconfi.Application.Services.Interface;

namespace OpenSiconfi.Application.Controllers
{
  public partial class AbstractController : ControllerBase
  {
    private IAbstractService Service { get; set; }

    public AbstractController(IAbstractService service)
    {
      Service = service;
    }

    [HttpGet("props")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 600)]
    public OSMensagem GetEntityProperties()
    {
      return new OSMensagem(Service.GetEntityProperties());
    }
  }
}