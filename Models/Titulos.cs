using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Titulos
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public int Premiacao { get; set; }
        public string Campeonato { get; set; }
        public string Artilheiro { get; set; }
    }
}