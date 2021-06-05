using System.Collections.Generic;
using System.Threading.Tasks;
using Back_End.Data.Interfaces;
using Back_End.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers
{
    [Route("api/pontos")]
    [ApiController]
    public class PontoTuristicoController : ControllerBase
    {

        private readonly IPontoTuristico _repoPontoTuristico;
        public PontoTuristicoController(IPontoTuristico repoPontoTuristico)
        {
            _repoPontoTuristico = repoPontoTuristico;
            
        }


        /// <summary>
        /// Listar todos os pontos turisticos
        /// </summary>
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<PontoTuristico>>> ListarPontos()
        {
            var pontos = await _repoPontoTuristico.GetAllPontoTuristicoAsync();
            return Ok(pontos);
        }

        /// <summary>
        /// Criar novo ponto turistico
        /// </summary>
        [HttpPost]
        [Route("novo")]
        public async Task<ActionResult> NovoPonto(PontoTuristico model)
        {
                var Ponto = new PontoTuristico()
                {
                    Nome = model.Nome,
                    Descricao = model.Descricao,
                    Localizacao = model.Localizacao
                };
               await _repoPontoTuristico.AddPontoTuristicoAsync(Ponto);
               return Ok(Ponto);
               
        }
    }
}