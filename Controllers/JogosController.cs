using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AspNet5Desafio.Models;
using AspNet5Desafio.Services;

namespace AspNet5Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosController : ControllerBase
    {
        private readonly IJogosService _jogosService;

        public JogosController(IJogosService jogosService)
        {
            _jogosService = jogosService;
        }

        [HttpGet]
        [Route("ListarJogos")]
        public IEnumerable<JogosModel> ListarJogos()
        {
            return _jogosService.ListarJogos();
        }

        [HttpPost]
        [Route("BuscarJogo")]
        public JogosModel BuscarJogo(JogosModel jogo)
        {
            return _jogosService.BuscarJogo(jogo);
        }

        [HttpPost]
        [Route("AdicionarJogo")]
        public void AdicionarJogo(JogosModel jogo)
        {
            _jogosService.AdicionarJogo(jogo);
        }

        [HttpPatch]
        [Route("AtualizarJogo")]
        public void AtualizarJogo(JogosModel jogo)
        {
            _jogosService.AtualizarJogo(jogo);
        }

        [HttpDelete]
        [Route("DeletarJogo")]
        public void DeletarJogo(JogosModel jogo)
        {
            _jogosService.DeletarJogo(jogo);
        }



    }
}
