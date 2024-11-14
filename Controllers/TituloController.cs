using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TituloController
    {
        private static List<Titulos> titulos = new List<Titulos>()
        {
                new Titulos() {Id=1, Data="16/12/2012", Campeonato="Mundial de Clubes", Premiacao=1000000, Artilheiro="Paolo Guerrero"},
                new Titulos() {Id=2, Data="04/06/2012", Campeonato="Libertadores da America", Premiacao=2000000, Artilheiro="Emerson Sheik"},
                new Titulos() {Id=3, Data="15/11/2017", Campeonato="Brasileirao Serie A", Premiacao=1000000, Artilheiro="Jo"}

        };

    }
}