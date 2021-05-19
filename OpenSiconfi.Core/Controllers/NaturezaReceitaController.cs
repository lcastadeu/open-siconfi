using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class NaturezaReceitaController : AbstractController
    {
        public NaturezaReceitaController(INaturezaReceitaService service)
        {
            Service = service;
        }
    }
}