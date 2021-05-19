using Microsoft.AspNetCore.Mvc;

namespace OpenSiconfi.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : AbstractController
    {
        [HttpGet]
        public IActionResult Index()
        {   
            return Ok("Serviço Ativo!");
        }
    }
}