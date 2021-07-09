using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Core.Services.Interface;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Application.Controllers
{
  [ApiVersion("1.0")]
  [Produces("application/json")]
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