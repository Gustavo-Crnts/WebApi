using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Jogador> TB_JOGADORES { get; set; }
        public DbSet<Jogador> TB_TITULOS { get; set; }
        public DbSet<Jogador> TB_PARTIDAS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Jogador>().ToTable("TB_JOGADORES");

            modelBuilder.Entity<Jogador>().HasData
            (
                new Jogador() { Id = 1, Nome = "Rodrigo Garro", Posicao = Models.Enuns.PosicaoEnum.Meia, Salario = 700000, Partidas = 50, Gols = 10, Assistencias = 13 },
                new Jogador() { Id = 2, Nome = "Andre Ramalho", Posicao = Models.Enuns.PosicaoEnum.Defensor, Salario = 500000, Partidas = 35, Gols = 1, Assistencias = 1 },
                new Jogador() { Id = 3, Nome = "Hugo Souza", Posicao = Models.Enuns.PosicaoEnum.Goleiro, Salario = 350000, Partidas = 28, Gols = 0, Assistencias = 0 },
                new Jogador() { Id = 4, Nome = "Yuri Alberto", Posicao = Models.Enuns.PosicaoEnum.Atacante, Salario = 1500000, Partidas = 60, Gols = 26, Assistencias = 8 },
                new Jogador() { Id = 5, Nome = "Memphis Depay", Posicao = Models.Enuns.PosicaoEnum.Atacante, Salario = 3000000, Partidas = 10, Gols = 3, Assistencias = 4 }
            );

            modelBuilder.Entity<Titulos>().ToTable("TB_TITULOS");

            modelBuilder.Entity<Titulos>().HasData
            (
                new Titulos() { Id = 1, Data = "16/12/2012", Campeonato = "Mundial de Clubes", Premiacao = 1000000, Artilheiro = "Paolo Guerrero" },
                new Titulos() { Id = 2, Data = "04/06/2012", Campeonato = "Libertadores da America", Premiacao = 2000000, Artilheiro = "Emerson Sheik" },
                new Titulos() { Id = 3, Data = "15/11/2017", Campeonato = "Brasileirao Serie A", Premiacao = 1000000, Artilheiro = "Jo" }
            );

            modelBuilder.Entity<Partidas>().ToTable("TB_PARTIDAS");

            modelBuilder.Entity<Partidas>().HasData
            (
                new Partidas() { Id = 1, Dia = "16/12/2015", Horario = "21:30", Competicao = "Brasileirao Serie A", Estadio = "Maracana", Adversario = "Flamengo", Resultado = "Vitoria", Placar = "3x0" },
                new Partidas() { Id = 2, Dia = "23/10/2024", Horario = "21:00", Competicao = "Sulamericana", Estadio = "Neo Quimica Arena", Adversario = "Racing", Resultado = "Empate", Placar = "2x2" },
                new Partidas() { Id = 3, Dia = "01/12/2024", Horario = "19:00", Competicao = "Copa do Brasil", Estadio = "Allianz Parque", Adversario = "Palmeiras", Resultado = "Vitoria", Placar = "51x0" }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveColumnType("varchar").HaveMaxLength(200);

        }



    }
}
