using Consignado.Application.Services;
using Consignado.Core.Entidades;
using ConsignadoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsignadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsignadoController : ControllerBase
    {
        private readonly ILiberaCreditoService _creditoService;

        public ConsignadoController(ILiberaCreditoService liberaCreditoService)
        {
            _creditoService = liberaCreditoService;
        }

        [HttpPost]
        public IActionResult AvaliarCredito([FromBody] CreditoConsignado consignado)
        {
            var credito = _creditoService.AvaliarCredito(consignado);

            return Ok(credito);
        }
    }
}
