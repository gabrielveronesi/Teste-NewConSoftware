using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Data.Interfaces;
using Back_End.Helpers;
using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using QRExpresso.API.Controllers;

namespace Back_End.Controllers
{
    [Route("api/pontos")]
    [ApiController]
    public class PontoTuristicoController : MainController
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
        public async Task<ActionResult<List<PontoTuristico>>> ListarPontos([FromQuery]PaginaParametros paginaParametros)
        {
            var pontos = await _repoPontoTuristico.GetAllPontoTuristicoAsync(paginaParametros);
            return Resposta(true, new{pontos});
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
                    Localizacao = model.Localizacao,
                    Cidade = model.Cidade,
                    Estado = model.Estado
                };
                
               await _repoPontoTuristico.AddPontoTuristicoAsync(Ponto);
               return Ok(Ponto);
               
        }

        /// <summary>
        /// Método responsavel para retornar 1 Ponto pelo ID
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult PegarPontoId(int id)
        {
            var ponto =  _repoPontoTuristico.GetPontoTuristicoByIdAsync(id);

            return Ok(ponto);
        }
    }
}