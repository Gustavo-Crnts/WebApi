﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241114002127_IntialCreate")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Assistencias")
                        .HasColumnType("int");

                    b.Property<int>("Gols")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<int>("Partidas")
                        .HasColumnType("int");

                    b.Property<int>("Posicao")
                        .HasColumnType("int");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_JOGADORES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assistencias = 13,
                            Gols = 10,
                            Nome = "Rodrigo Garro",
                            Partidas = 50,
                            Posicao = 3,
                            Salario = 700000
                        },
                        new
                        {
                            Id = 2,
                            Assistencias = 1,
                            Gols = 1,
                            Nome = "Andre Ramalho",
                            Partidas = 35,
                            Posicao = 2,
                            Salario = 500000
                        },
                        new
                        {
                            Id = 3,
                            Assistencias = 0,
                            Gols = 0,
                            Nome = "Hugo Souza",
                            Partidas = 28,
                            Posicao = 1,
                            Salario = 350000
                        },
                        new
                        {
                            Id = 4,
                            Assistencias = 8,
                            Gols = 26,
                            Nome = "Yuri Alberto",
                            Partidas = 60,
                            Posicao = 4,
                            Salario = 1500000
                        },
                        new
                        {
                            Id = 5,
                            Assistencias = 4,
                            Gols = 3,
                            Nome = "Memphis Depay",
                            Partidas = 10,
                            Posicao = 4,
                            Salario = 3000000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
