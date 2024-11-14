using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JogadorController : ControllerBase
    {
        private static List<Jogador> jogadores = new List<Jogador>()  
         {
            new Jogador() {Id = 1, Nome = "Rodrigo Garro", Posicao=Models.Enuns.PosicaoEnum.Meia, Salario=700000, Partidas=50, Gols=10, Assistencias=13},
            new Jogador() {Id = 2, Nome = "Andre Ramalho", Posicao=Models.Enuns.PosicaoEnum.Defensor, Salario=500000, Partidas=35, Gols=1, Assistencias=1},
            new Jogador() {Id = 3, Nome = "Hugo Souza", Posicao=Models.Enuns.PosicaoEnum.Goleiro, Salario=350000, Partidas=28, Gols=0, Assistencias=0},
            new Jogador() {Id = 4, Nome = "Yuri Alberto", Posicao=Models.Enuns.PosicaoEnum.Atacante, Salario=1500000, Partidas=60, Gols=26, Assistencias=8},
            new Jogador() {Id = 5, Nome = "Memphis Depay", Posicao=Models.Enuns.PosicaoEnum.Atacante, Salario=3000000, Partidas=10, Gols=3, Assistencias=4},
         };

    
         

         [HttpGet ("Get")]
         public IActionResult GetFirst()
         {
            return Ok(jogadores[0]);
         }

          [HttpGet ("GetAll")]
         public IActionResult Get()
         {
            return Ok(jogadores);
         }

        

        [HttpGet("{id}")]
        public IActionResult GetSingle(int Id)
        {
            return Ok(jogadores.FirstOrDefault(jo => jo.Id == Id));
        }

        [HttpPost]
        public IActionResult AddPersonagem(Jogador novoJogador)
        {
            jogadores.Add(novoJogador);
            return Ok(jogadores);
        }

        [HttpGet("GetOrdenado")]
        public IActionResult GetOrdem()
        {
            List<Jogador> listaFinal = jogadores.OrderBy(j => j.Gols).ToList();
            return Ok(listaFinal);
        }
    }
}