using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Encodings.Web;
using OpenSiconfi.Infrastructure;
using OpenSiconfi.Application.Services.Interface;

namespace OpenSiconfi.Application.Controllers
{
  public partial class AbstractController : ControllerBase
  {
    protected IAbstractService Service { get; set; }

    [HttpGet("props")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
    public OSMensagem GetEntityProperties()
    {
      return new OSMensagem(Service.GetEntityProperties());

    }
  }
}