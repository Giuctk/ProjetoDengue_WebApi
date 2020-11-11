using API.DTO;
using Business.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtendimentoController : ControllerBase
    {
        private IAtendimentoService _atendimentoService;
        public AtendimentoController(IAtendimentoService atendimentoService)
        {
            _atendimentoService = atendimentoService;
        }

        [HttpGet]
        public IActionResult PegaTodos()
        {
            return NotFound();
        }

        [HttpPost]
        public IActionResult Criar([FromBody]AtendimentoViewModel model)
        {
            try
            {
                var retorno = _atendimentoService.CriaAtendimento(model);

                return Ok(retorno);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
