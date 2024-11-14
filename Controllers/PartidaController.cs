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
    public class PartidaController
    {
        private static List<Partidas> partidas = new List<Partidas>()
        {
                new Partidas() {Id=1, Dia="16/12/2015", Horario="21:30", Competicao="Brasileirao Serie A", Estadio="Maracana", Adversario="Flamengo", Resultado="Vitoria", Placar="3x0" },
                new Partidas() {Id=2, Dia="23/10/2024", Horario="21:00", Competicao="Sulamericana", Estadio="Neo Quimica Arena", Adversario="Racing", Resultado="Empate", Placar="2x2" },
                new Partidas() {Id=3, Dia="01/12/2024", Horario="19:00", Competicao="Copa do Brasil", Estadio="Allianz Parque", Adversario="Palmeiras", Resultado="Vitoria", Placar="51x0" }

        };
    }
}