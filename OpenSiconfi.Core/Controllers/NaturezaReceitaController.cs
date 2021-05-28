using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Application.Controllers
{
    [ApiController]
    [Route("api/v{verion:apiVersion}/[controller]/")]
    public class NaturezaReceitaController : AbstractController
    {
        protected INaturezaReceitaService Service {get; set;}
        public NaturezaReceitaController(INaturezaReceitaService service) : base(service)
        {
            Service = service;
        }
    }
}