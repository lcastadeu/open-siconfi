using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Core.Services.Interface;

namespace OpenSiconfi.Application.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StatusController : AbstractController
  {
    public StatusController(IAbstractService service) : base(service)
    {
        
    }

    [HttpGet]
    public IActionResult Index()
    {
      return Ok("Serviço Ativo!");
    }
  }
}