using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Application.Services.Interface;

namespace OpenSiconfi.Application.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
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